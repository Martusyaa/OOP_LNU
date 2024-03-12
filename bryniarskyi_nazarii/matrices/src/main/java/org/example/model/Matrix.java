package org.example.model;


import lombok.*;

import java.util.Arrays;

@AllArgsConstructor
@NoArgsConstructor
@EqualsAndHashCode
@Getter
@Setter
public class Matrix {

    private int[][] matrix;

    @Override
    public String toString() {
        final StringBuilder result = new StringBuilder();
        if (matrix != null) {
            for (int[] row : matrix) {
                result.append(Arrays.toString(row)).append("\n");
            }
        }
        return result.toString();
    }
}
