from uuid import uuid4

def get_uuid():
    return str(uuid4())

def jwt_get_username_from_payload_handler(payload):
    """
    Override this function if username is formatted differently in payload
    """
    return payload.get('user').get('email')
