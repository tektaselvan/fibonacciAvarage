public class avarageCalculator{
    public double CalculateAvarage(int[] array){
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return (double)sum / array.Length;
    }
}