package org.example.abstract_factory.service.factory;

import org.example.abstract_factory.model.User;
import org.example.abstract_factory.service.user_bl.Privileges;
import org.example.abstract_factory.service.user_bl.ProfileEdit;

public interface UserFactory<T extends User> {

    Privileges<T> createPrivileges();

    ProfileEdit createProfileEdit();
}
