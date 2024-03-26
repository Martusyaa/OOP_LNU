package org.example.abstract_factory.service.user_bl;

import org.example.abstract_factory.model.SimpleUser;

import java.util.List;

public class SimpleUserBL implements Privileges<SimpleUser>, ProfileEdit<SimpleUser> {

    @Override
    public List<String> listOfPrivileges(final SimpleUser user) {
        return null;
    }

    @Override
    public boolean hasAccess(final SimpleUser user,
                             final String api) {
        return false;
    }

    @Override
    public boolean changeName(final SimpleUser user,
                              final String name) {
        return false;
    }
}
