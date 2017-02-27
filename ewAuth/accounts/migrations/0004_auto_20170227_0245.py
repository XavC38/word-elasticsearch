# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations


class Migration(migrations.Migration):

    dependencies = [
        ('accounts', '0003_auto_20170227_0233'),
    ]

    operations = [
        migrations.AlterField(
            model_name='tenant',
            name='date_of_birth',
            field=models.DateField(null=True, blank=True),
        ),
    ]
