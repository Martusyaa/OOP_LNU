public class DifferentMatrix extends Exception {

    private final String message;

    public DifferentMatrix(String message){
        this.message = message;
    }

    @Override
    public String toString() {
        return message;
    }
}
