# Generated by Django 4.2.7 on 2023-11-17 00:05

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('Tasks', '0033_usertreenode_userbinarysearchtree_group_adminlist_and_more'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='group',
            name='adminList',
        ),
        migrations.AddField(
            model_name='usertreenode',
            name='admin',
            field=models.BooleanField(default=False),
        ),
    ]