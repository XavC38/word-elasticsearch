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
