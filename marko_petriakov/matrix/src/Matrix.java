import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;

public class Matrix {

    private ArrayList<ArrayList<Integer>> matrix = new ArrayList<>();

    private Matrix(ArrayList<ArrayList<Integer>> matrix){
        this.matrix=matrix;
    }
    public Matrix(String path) throws IOException {
        setMatrix(ReadMatrix.read(path));
    }

    public void add(Matrix secondAddend) throws DifferentMatrix {

        MatrixHandling.checkAddSub(this,secondAddend);


        ArrayList<ArrayList<Integer>> result = new ArrayList<>();

        for (int i = 0; i < matrix.size(); i++){
            ArrayList<Integer> tempRow= new ArrayList<>();
            for (int j = 0; j < matrix.get(0).size(); j++){
                tempRow.add(matrix.get(i).get(j) + secondAddend.matrix.get(i).get(j));
            }
            result.add(tempRow);
        }
        this.setMatrix(result);
    };

   public void subtract(Matrix subtrahend) throws DifferentMatrix {

       MatrixHandling.checkAddSub(this,subtrahend);

       ArrayList<ArrayList<Integer>> result = new ArrayList<>();

       for (int i = 0; i < matrix.size(); i++){
           ArrayList<Integer> tempRow= new ArrayList<>();
           for (int j = 0; j < subtrahend.matrix.get(0).size(); j++){
               tempRow.add(matrix.get(i).get(j) - subtrahend.matrix.get(i).get(j));
           }
           result.add(tempRow);
       }
       this.setMatrix(result);
   };

     public Matrix multiply(Matrix secondMultiplier){
         int [][] arr = new int [matrix.get(0).size()][secondMultiplier.matrix.size()];

         for (int i = 0; i< matrix.size(); i++){
             for (int j = 0; j < secondMultiplier.matrix.get(0).size(); j++) {
                 for (int k = 0; k < secondMultiplier.matrix.size(); k++) {
                     arr[i][j] += matrix.get(i).get(k)* secondMultiplier.matrix.get(k).get(j);
                 }
             }
         }
         ArrayList<ArrayList<Integer>> result = new ArrayList<>();
         for (int i = 0; i <matrix.get(0).size(); i++) {
             ArrayList<Integer> temp = new ArrayList<>();
             Arrays.stream(arr[i]).forEach(temp::add);
             result.add(temp);
         }

         return new Matrix(result);

     };

    public static Matrix divide(Matrix matrixToDivide){

    return new Matrix(matrixToDivide.matrix); // change param
    };


    public ArrayList<ArrayList<Integer>> getMatrix() {
        return matrix;
    }

    public void setMatrix(ArrayList<ArrayList<Integer>> matrix) {
        this.matrix = matrix;
    }

    @Override
    public String toString() {
        return matrix.toString();
    }
};







