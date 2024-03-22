using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.


namespace NotificadorMain;

public class Function
{

    /// <summary>
    /// A simple function that takes a string and returns both the upper and lower case version of the string.
    /// </summary>
    /// <param name="input"> The event for the Lambda function handler to process.</param>
    /// <param name="context"> The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
    /// <returns></returns>

    [LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

    public string FunctionHandler(MyData data, ILambdaContext context)
    {
        return $"Hola {data.Name}".ToUpper();
    }
}

public class MyData
{
    public string Name { get; set; }
}