using System;
using System.Net;
using System.Net.Sockets;
using MetroThing.Types.Validation;

namespace MetroThing.Core
{
    public static class UserInputValidator
    {
        public static ValidationResult<UInt16> ValidateNetworkPortNumber(string port)
        {
            var result = new ValidationResult<UInt16>();

            try
            {
                result.ValidatedValue = Convert.ToUInt16(port);
            }
            catch (FormatException)
            {
                result.Message = "Invalid port format given, must be numeric";
            }
            catch (OverflowException)
            {
                result.Message = "Invalid port range, must be between 1 and 65535";
            }

            return result;
        }

        public static ValidationResult<string> ValidateNetworkHostname(string hostname)
        {
            var result = new ValidationResult<string>();

            hostname = hostname.Trim().ToLower();
            var hostnameValidation = Uri.CheckHostName(hostname);

            // Sanity check
            if (hostnameValidation == UriHostNameType.Unknown)
            {
                result.Message = string.IsNullOrWhiteSpace(hostname)
                    ? "No hostname given"
                    : "The given hostname is invalid";
                return result;
            }

            result.ValidatedValue = hostname;

            // Hostname lookup
            if (hostnameValidation == UriHostNameType.Dns)
            {
                // Invalidate current result, more checks required
                result.ValidatedValue = null;

                try
                {
                    Dns.GetHostEntry(hostname);
                    result.ValidatedValue = hostname;
                }
                catch (ArgumentOutOfRangeException)
                {
                    result.Message = "Given hostname exceeds the maximum hostname length of 255 characters";
                }
                catch (SocketException)
                {
                    result.Message = "Could not resolve \"" + hostname + "\"";
                }
                catch (ArgumentException)
                {
                    result.Message = "Given hostname is an invalid IP address";
                }
            }

            return result;
        }

        public static ValidationResult<string> ValidateSyncthingApiKey(string apiKey)
        {
            var result = new ValidationResult<string>();

            apiKey = apiKey.Trim();

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                result.Message = "API key is empty";
            }
            else
            {
                result.ValidatedValue = apiKey;
            }

            return result;
        }

        public static ValidationResult<string> ValidateSyncthingDisplayName(string displayName)
        {
            var result = new ValidationResult<string>();

            displayName = displayName.Trim();

            if (!string.IsNullOrWhiteSpace(displayName))
            {
                result.ValidatedValue = displayName;
            }

            return result;
        }
    }
}