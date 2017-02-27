import jwt
import uuid
from calendar import timegm
from datetime import datetime
from django.shortcuts import render
from django.contrib.auth import get_user_model
from rest_framework.decorators import api_view
from rest_framework.response import Response
from rest_framework.generics import (
    CreateAPIView
)

from rest_framework_jwt.compat import (
    get_username,
    get_username_field
)

from rest_framework_jwt.settings import api_settings

from .serializers import (
    UserCreateSerializer,
    TenantSerializer,
    UserSerializer
)

User = get_user_model()

@api_view(['GET'])
def ping(request):
    return Response({"message":"Boom, you got it !"})

class UserCreateAPIView(CreateAPIView):
    serializer_class = UserCreateSerializer
    queryset = User.objects.all()



def jwt_response_payload_handler(token, user=None, request=None):
    """
    Returns the response data for both the login and refresh views.
    Override to return a custom response such as including the
    serialized representation of the User.
    Example:
    def jwt_response_payload_handler(token, user=None, request=None):
        return {
            'token': token,
            'user': UserSerializer(user, context={'request': request}).data
        }
    """
    return {
        'token': token,
        'user': UserSerializer(user, context={'request': request}).data
    }

def jwt_payload_handler(user):
    username_field = get_username_field()
    username = get_username(user)

    payload = {
        'user': UserSerializer(user).data,
        'exp': datetime.utcnow() + api_settings.JWT_EXPIRATION_DELTA
    }

    # if isinstance(user.pk, uuid.UUID):
    #     payload['user_id'] = str(user.pk)

    # payload[username_field] = username

    # Include original issued at time for a brand new token,
    # to allow token refresh
    if api_settings.JWT_ALLOW_REFRESH:
        payload['orig_iat'] = timegm(
            datetime.utcnow().utctimetuple()
        )

    if api_settings.JWT_AUDIENCE is not None:
        payload['aud'] = api_settings.JWT_AUDIENCE

    if api_settings.JWT_ISSUER is not None:
        payload['iss'] = api_settings.JWT_ISSUER

    return payload
