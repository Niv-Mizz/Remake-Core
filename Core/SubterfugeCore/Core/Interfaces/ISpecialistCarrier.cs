﻿using SubterfugeCore.Core.Entities.Specialists;

namespace SubterfugeCore.Core.Interfaces
{
    /// <summary>
    /// Anything that is able to carry specialists
    /// </summary>
    public interface ISpecialistCarrier
    {
        /// <summary>
        /// Returns the specialist manager for the object.
        /// </summary>
        /// <returns>The specialist manager</returns>
        SpecialistManager GetSpecialistManager();
    }
}
