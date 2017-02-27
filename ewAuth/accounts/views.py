import jwt
import uuid
from rest_framework_jwt.settings import api_settings
from calendar import timegm
from datetime import datetime
from django.shortcuts import render
from django.contrib.auth import get_user_model
from rest_framework.decorators import api_view
from rest_framework.response import Response
from rest_framework import status
from rest_framework.generics import (
    CreateAPIView
)

from rest_framework_jwt.compat import (
    get_username,
    get_username_field
)

from rest_framework.views import (
    APIView
)

from .serializers import (
    UserCreateSerializer,
    TenantSerializer,
    UserSerializer,
    VerifyJSONWebTokenSerializer
)

from .utils import (
    jwt_response_with_id_payload_handler
)

User = get_user_model()

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

def jwt_payload_handler_with_id(user):
    username_field = get_username_field()
    username = get_username(user)

    payload = {
        'user': TenantSerializer(user).data,
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

@api_view(['GET'])
def ping(request):
    return Response({"message":"Boom, you got it !"})

class UserCreateAPIView(CreateAPIView):
    serializer_class = UserCreateSerializer
    queryset = User.objects.all()

class TenantIdDetailView(APIView):

    def post(self, request, *args, **kwargs):
        serializer = VerifyJSONWebTokenSerializer(data=request.data)

        if serializer.is_valid():
            user = serializer.validated_data.get('user')
            token = serializer.validated_data.get('token')
            response_data = jwt_response_with_id_payload_handler(token, user, request)

            return Response(response_data)

        return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)


verify_jwt_token = TenantIdDetailView.as_view()
