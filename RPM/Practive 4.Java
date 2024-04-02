import java.util.ArrayList;
public class Main {
    public static int rnd(int min, int max){
        return  (int) (Math.random() * (max-min) + min);
    }
    public static ArrayList<Integer> ArrayGenerate() {
        ArrayList<Integer> arr = new ArrayList<>();
        for(int i = 0; i < 10; ++i){
            arr.add(rnd(-100,100));
        }
        return arr;
    }
    public static void Rarr(){
        ArrayList<Integer> arr;
        arr = ArrayGenerate();
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
    public static void ReversArray(ArrayList<Integer> StandartArray) {
        System.out.println("Standart Array: " + StandartArray);
        System.out.println("Revaers Array : " + StandartArray.reversed());
    }
    public static void MaxAndMin(){
        ArrayList<Integer> Arr;
        Arr = ArrayGenerate();
        System.out.println(Arr);
        int MaxValue = Arr.get(0);
        for(int j : Arr){
            if(j > MaxValue){
                MaxValue=j;
            }
        }
        System.out.printf("Max value:%d\n",MaxValue);

        int MinValue = Arr.get(0);
        for(int h : Arr){
            if(h < MinValue){
                MinValue = h;
            }
        }
        System.out.printf("Min value%d:\n", MinValue);
    }
    public static void main(String[] args) {
        Rarr();
        ReversArray(ArrayGenerate());
        MaxAndMin();
    }
}