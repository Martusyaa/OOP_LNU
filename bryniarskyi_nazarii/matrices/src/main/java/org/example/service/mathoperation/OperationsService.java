package org.example.service.mathoperation;

public interface OperationsService<T> {

    T add(final T firstElement,
          final T secondElement);

    T subtract(final T firstElement,
               final T secondElement);

    T multiply(final T firstElement,
               final T secondElement);
}
