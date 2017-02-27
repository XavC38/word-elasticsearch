import uuid

def get_uuid():
    return str(uuid.uuid4())

def jwt_get_username_from_payload_handler(payload):
    """
    Override this function if username is formatted differently in payload
    """
    return payload.get('user').get('email')


def jwt_response_with_id_payload_handler(token, user=None, request=None):
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
    payload = {
        'token': token,
    }

    if isinstance(user.pk, uuid.UUID):
        payload['user_id'] = str(user.pk)

    return payload
