namespace Shopper.Core.Exceptions;

public class NotFoundException(string resourceType, string resourceField, string resourceIdentifier)
    : Exception($"{resourceType} with {resourceField} of {resourceIdentifier} was not found.")
{
}
