package org.example.abstract_factory.service.user_bl;

import org.example.abstract_factory.model.User;

import java.util.List;

public interface Privileges<T extends User> {

    List<String> listOfPrivileges(final T user);

    boolean hasAccess(final T user,
                      final String api);
}
