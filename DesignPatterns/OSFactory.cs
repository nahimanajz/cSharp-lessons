
public class OSFactory
{

    public Os GetInstance(string osType)
    {
        if (osType == "android")
        {
            return new Android();
        }
        else if (osType == "ios")
        {
            return new IOS();
        }
        else
        {
            return new Windows();
        }

    }
}