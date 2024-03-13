import java.io.IOException;

public class Main {

    public static void main(String[] args) throws IOException, DifferentMatrix {
        Matrix a = new Matrix("src/entity/file.txt");
        System.out.println(a);
        Matrix b = new Matrix("src/entity/file2.txt");
        System.out.println(b);
        //Addition
        a.add(b);
        System.out.println(a);



        //Subtraction
//        Matrix result = Matrix.subtract(a,b);
//        System.out.println(result);
        //Multiplication
//        Matrix result = Matrix.multiply(a,b);
//        System.out.println(result);

    }
}
