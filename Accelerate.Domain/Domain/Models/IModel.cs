using System;
using System.Runtime.Serialization;

namespace Accelerate.Domain.Models
{
    /// <summary>
    /// Domain model.
    /// </summary>
    public interface IModel : IDisposable, ISerializable, ICloneable
    {
    }
}
