package org.example.abstract_factory.service.factory;

import org.example.abstract_factory.model.SimpleUser;
import org.example.abstract_factory.service.user_bl.Privileges;
import org.example.abstract_factory.service.user_bl.ProfileEdit;
import org.example.abstract_factory.service.user_bl.SimpleUserBL;


public class SimpleUserFactory implements UserFactory<SimpleUser> {

    @Override
    public Privileges<SimpleUser> createPrivileges() {
        return new SimpleUserBL();
    }

    @Override
    public ProfileEdit<SimpleUser> createProfileEdit() {
        return new SimpleUserBL();
    }
}
