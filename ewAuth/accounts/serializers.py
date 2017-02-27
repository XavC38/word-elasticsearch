from django.contrib.auth import get_user_model

from rest_framework.serializers import(
    ModelSerializer,
)


User = get_user_model()

class UserCreateSerializer(ModelSerializer):
    class Meta:
        model = User
        fields = [
            'email',
            'password',
        ]

class TenantSerializer(ModelSerializer):
    class Meta:
        model = User
        fields = [
            'id',
            'email',
        ]
