package converter;

public class ConvertFunctions {

    public static String CtoF(float c)
    {
        float f=c*9.0f/5.0f+32;
        return Float.toString(f);
    }

    public static String CtoK(float c)
    {
        float k=c+273.15f;
        return Float.toString(k);
    }


    public static String FtoC(float f)
    {
        float c=(f-32)*5f/9f;
        return Float.toString(c);
    }

    public static String  FtoK(float f)
    {
        float k=(f+459.67f)*5f/9f;
        return Float.toString(k);
    }

    public static String  KtoC(float k)
    {
        float c=k-273.15f;
        return Float.toString(c);
    }

    public static String  KtoF(float k)
    {
        float f=k*9f/5f-459.67f;
        return Float.toString(f);
    }





}
