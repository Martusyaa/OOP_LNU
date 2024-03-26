package org.example.abstract_factory.service.user_bl;

import org.example.abstract_factory.model.User;

public interface ProfileEdit<T extends User> {

    boolean changeName(final T user,
                       final String name);
}
