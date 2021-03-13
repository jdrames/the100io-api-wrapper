# The100API
A .net wrapper for www.the100.io API.  
Mapped endpoints available with synchronous and asynchronous methods.  
Synchronous methods are just wrapped asyncronous methods.

All methods will throw an `ApiException` if the request was not successful.

```
ApiException {
    <string> Message: Message indicating there was an API request error.
    <string> StatusCode: The http response code received back from the API request.
    <string> StatusMessage: The reason phrase send from the API server with the StatusCode.
}
```
  
You must obtain an API token from www.the100.io.

## Example Usage

```csharp
...
    var the100 = new The100API("your-api-token-here");
    var games = await the100.Games.GetGamesAsync();
    Console.WriteLine("The100 Games");
    foreach(var game in games){
        Console.WriteLine(game.Name);
    }
...    
```

## TODO
Add additional user endpoints that are user specific access only. 
This wrapper is meant for endpoints that are to be accessed via a groups 
access token.  
