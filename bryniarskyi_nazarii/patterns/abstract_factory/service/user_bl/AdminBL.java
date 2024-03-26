package org.example.abstract_factory.service.user_bl;

import org.example.abstract_factory.model.Admin;

import java.util.List;

public class AdminBL implements Privileges<Admin>, ProfileEdit<Admin> {

    @Override
    public List<String> listOfPrivileges(final Admin user) {
        return null;
    }

    @Override
    public boolean hasAccess(final Admin user,
                             final String api) {
        return false;
    }

    @Override
    public boolean changeName(final Admin user,
                              final String name) {
        return false;
    }
}
