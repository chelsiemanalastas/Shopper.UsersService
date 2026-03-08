namespace Shopper.Application.Exceptions;

public class NotFoundException(string resourcetype, string resourceField, string resourceValue)
    : Exception($"{resourcetype} with {resourceField} of {resourceValue} was not found.")
{
}
