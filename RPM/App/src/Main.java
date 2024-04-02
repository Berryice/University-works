import java.util.ArrayList;
public class Main {
    public static int rnd(int min, int max){
        return  (int) (Math.random() * (max-min) + min);
    }
    public static void Rarr(){
        ArrayList<Integer> arr = new ArrayList<Integer>();
        for(int i = 0; i < 10; ++i){
            arr.add(rnd(-100,100));
        }
        System.out.println(arr);
        int positive = 0, negative = 0;
        for(int num : arr){
            if(num > 0){
                ++positive;
            }
            if(num < 0){
                ++negative;
            }
        }
        System.out.println("Позитивных "+positive +" негативных " + negative);
    }
    public static void main(String[] args) {
        for(int h = 0; h < 10; ++h){
            Rarr();
        }
    }
}