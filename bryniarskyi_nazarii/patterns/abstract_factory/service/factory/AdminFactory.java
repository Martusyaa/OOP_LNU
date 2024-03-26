package org.example.abstract_factory.service.factory;

import org.example.abstract_factory.model.Admin;
import org.example.abstract_factory.service.user_bl.AdminBL;
import org.example.abstract_factory.service.user_bl.Privileges;
import org.example.abstract_factory.service.user_bl.ProfileEdit;


public class AdminFactory implements UserFactory<Admin> {

    @Override
    public Privileges<Admin> createPrivileges() {
        return new AdminBL();
    }

    @Override
    public ProfileEdit<Admin> createProfileEdit() {
        return new AdminBL();
    }
}
