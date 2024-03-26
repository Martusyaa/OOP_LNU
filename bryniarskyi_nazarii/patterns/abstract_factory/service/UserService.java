package org.example.abstract_factory.service;

import org.example.abstract_factory.service.factory.AdminFactory;
import org.example.abstract_factory.service.factory.SimpleUserFactory;
import org.example.abstract_factory.service.factory.UserFactory;
import org.example.abstract_factory.service.user_bl.Privileges;
import org.example.abstract_factory.service.user_bl.ProfileEdit;
import org.example.abstract_factory.util.UserType;


public abstract class UserService {

    private UserFactory userFactory;

    public UserService(UserType userType) {
        switch (userType) {
            case ADMIN -> userFactory = new AdminFactory();
            case SIMPLE_USER -> userFactory = new SimpleUserFactory();
        }
    }

    public Privileges getPrivileges() {
        return userFactory.createPrivileges();
    }

    public ProfileEdit getProfileEdit() {
        return userFactory.createProfileEdit();
    }
}
