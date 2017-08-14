using System;
using PrincessFrogPatterLib.Strategy.Interfaces;

namespace PrincessFrogPatterLib.Strategy
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}