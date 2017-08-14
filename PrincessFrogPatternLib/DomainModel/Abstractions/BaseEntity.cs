using System;
using PrincessFrogPatterLib.DomainModel.Interfaces;

namespace PrincessFrogPatterLib.DomainModel.Abstractions
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}