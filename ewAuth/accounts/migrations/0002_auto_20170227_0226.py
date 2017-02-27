# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations
import accounts.utils


class Migration(migrations.Migration):

    dependencies = [
        ('accounts', '0001_initial'),
    ]

    operations = [
        migrations.AlterField(
            model_name='tenant',
            name='tenant_id',
            field=models.CharField(default=accounts.utils.get_uuid, unique=True, max_length=50, editable=False),
        ),
    ]
