import jwt

from django.contrib.auth import get_user_model
from django.utils.translation import ugettext as _

from rest_framework.serializers import(
    ModelSerializer,
    Serializer,
    CharField,
    ValidationError
)

from rest_framework_jwt.settings import api_settings

User = get_user_model()
jwt_decode_handler = api_settings.JWT_DECODE_HANDLER
jwt_get_username_from_payload = api_settings.JWT_PAYLOAD_GET_USERNAME_HANDLER


class UserCreateSerializer(ModelSerializer):
    class Meta:
        model = User
        fields = [
            'email',
            'password',
        ]

class UserSerializer(ModelSerializer):
    class Meta:
        model = User
        fields = [
            'email',
            'date_of_birth',
            'is_admin',
        ]

class TenantSerializer(ModelSerializer):
    class Meta:
        model = User
        fields = '__all__'


class VerificationBaseSerializer(Serializer):
    """
    Abstract serializer used for verifying and refreshing JWTs.
    """
    token = CharField()

    def validate(self, attrs):
        msg = 'Please define a validate method.'
        raise NotImplementedError(msg)

    def _check_payload(self, token):
        # Check payload valid (based off of JSONWebTokenAuthentication,
        # may want to refactor)
        try:
            payload = jwt_decode_handler(token)
        except jwt.ExpiredSignature:
            msg = _('Signature has expired.')
            raise ValidationError(msg)
        except jwt.DecodeError:
            msg = _('Error decoding signature.')
            raise ValidationError(msg)

        return payload

    def _check_user(self, payload):
        username = jwt_get_username_from_payload(payload)

        if not username:
            msg = _('Invalid payload.')
            raise ValidationError(msg)

        # Make sure user exists
        try:
            user = User.objects.get_by_natural_key(username)
        except User.DoesNotExist:
            msg = _("User doesn't exist.")
            raise ValidationError(msg)

        if not user.is_active:
            msg = _('User account is disabled.')
            raise ValidationError(msg)

        return user


class VerifyJSONWebTokenSerializer(VerificationBaseSerializer):
    """
    Check the veracity of an access token.
    """

    def validate(self, attrs):
        token = attrs['token']

        payload = self._check_payload(token=token)
        user = self._check_user(payload=payload)
        print user
        print token 
        return {
            'token': token,
            'user': user
        }
