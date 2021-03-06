﻿using System;

namespace Ays
{
    /// <summary>
    /// I am the watcher on the walls. I am the fire that burns against the cold, the light that brings the dawn...
    /// </summary>
    public static class W
    {
        #region Public Methods

        public static void ArgumentAssignableFrom(Type targetType, Type argumentType, string argumentName)
        {
            ArgumentNotNull(targetType, nameof(targetType));
            ArgumentNotNull(argumentType, nameof(argumentType));
            ArgumentNotEmpty(argumentName, nameof(argumentName));

            if (targetType.IsAssignableFrom(argumentType))
            {
                throw E.Argument($"Target type '{targetType.FullName}' is not assignable from argument type '{argumentType.FullName}'.", argumentName);
            }
        }

        public static void ArgumentNotEmpty(string argument, string argumentName)
        {
            ArgumentNotEmpty(argumentName, nameof(argumentName));

            if (string.IsNullOrEmpty(argument))
            {
                throw E.ArgumentNull(argumentName);
            }
        }

        public static void ArgumentNotNull(object argument, string argumentName)
        {
            ArgumentNotEmpty(argumentName, nameof(argumentName));

            if (argument == null)
            {
                throw E.ArgumentNull(argumentName);
            }
        }

        public static void ArgumentPositive(int argument, string argumentName)
        {
            ArgumentNotEmpty(argumentName, nameof(argumentName));

            if (argument <= 0)
            {
                throw E.Argument("Argument value expected to be positive.", argumentName);
            }
        }

        public static string EnsureNotEmpty(string argument, string message)
        {
            ArgumentNotEmpty(message, nameof(message));

            if (string.IsNullOrEmpty(argument))
            {
                throw E.UnexpectedValue(message, argument);
            }

            return argument;
        }

        public static T EnsureNotNull<T>(T argument, string message)
        {
            ArgumentNotEmpty(message, nameof(message));

            if (argument == null)
            {
                throw E.UnexpectedValue(message, argument);
            }

            return argument;
        }

        #endregion Public Methods
    }
}