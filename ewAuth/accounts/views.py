from django.shortcuts import render
from django.contrib.auth import get_user_model
from rest_framework.decorators import api_view
from rest_framework.response import Response
from rest_framework.generics import (
    CreateAPIView
)

from .serializers import (
    UserCreateSerializer,
    TenantSerializer
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
        'user': TenantSerializer(user, context={'request': request}).data
    }
