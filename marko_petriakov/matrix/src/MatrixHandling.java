public class MatrixHandling  {

    private MatrixHandling(){}


    public static void checkAddSub(Matrix a, Matrix b) throws DifferentMatrix {
        if (a.getMatrix().size() != b.getMatrix().size() || a.getMatrix().get(0).size() != b.getMatrix().get(0).size()){
            throw new DifferentMatrix("Matrixes are not equal");
        }

    }
}
