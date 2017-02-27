from django.conf.urls import url
from .views import (
    ping,
    UserCreateAPIView,
    verify_jwt_token
    )

from djoser.views import (
    RegistrationView,
    PasswordResetView,
    PasswordResetConfirmView,
    LogoutView
)

from rest_framework_jwt.views import (
    obtain_jwt_token,
    refresh_jwt_token,
    # verify_jwt_token
)

urlpatterns = [
    url(r'^ping/$', ping, name='auth-ping'),
    url(r'^login/', obtain_jwt_token),
    url(r'^refresh/', refresh_jwt_token),
    url(r'^check/', verify_jwt_token),
    url(r'^logout/', LogoutView.as_view()),
    url(r'^register/$', RegistrationView.as_view(), name='register'),
    url(r'^password/reset', PasswordResetView.as_view(), name="pwd-reset"),
    url(r'^password/reset/confirm', PasswordResetConfirmView.as_view(), name="pwd-confirm"),
]
