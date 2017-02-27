# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations
import accounts.utils


class Migration(migrations.Migration):

    dependencies = [
        ('accounts', '0002_auto_20170227_0226'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='tenant',
            name='tenant_id',
        ),
        migrations.AlterField(
            model_name='tenant',
            name='id',
            field=models.UUIDField(default=accounts.utils.get_uuid, serialize=False, editable=False, primary_key=True),
        ),
    ]
