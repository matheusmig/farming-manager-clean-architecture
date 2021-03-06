﻿namespace Application.Base.Boundaries
{
    public interface IOutputPortStandard<in TUseCaseOutput>
    {
        /// <summary>
        /// Writes to the Standard Output.
        /// </summary>
        /// <param name="output">The Output Port Message.</param>
        void Standard(TUseCaseOutput output);
    }
}
