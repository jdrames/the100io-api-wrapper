# The100API
A .net wrapper for www.the100.io API.  
Mapped endpoints available with synchronous and asynchronous methods.  
Synchronous methods are just wrapped asyncronous methods.

All methods will throw an `ApiException` if the request was not successful.

```
ApiException : Exception {
    <string> Message: Message indicating there was an API request error.
    <string> StatusCode: The http response code received back from the API request.
    <string> StatusMessage: The reason phrase send from the API server with the StatusCode.
}
```
  
You must obtain an API token from www.the100.io.

## Notice
This library has been updated to version 2.0.0. It now used interfaces to help with Endpoint definitions.
If the TokenType supplied when creating the api object is a Group token then only the group accessible
user endpoints will be available. If the TokenType supplied is a User token then all user endpoints will be available.

## Example Usage
```csharp
...
    var the100 = new The100API(TokenType.Group, "your-api-token-here");
    var games = await the100.Games.GetGamesAsync();
    Console.WriteLine("The100 Games");
    foreach(var game in games){
        Console.WriteLine(game.Name);
    }
...    
```


