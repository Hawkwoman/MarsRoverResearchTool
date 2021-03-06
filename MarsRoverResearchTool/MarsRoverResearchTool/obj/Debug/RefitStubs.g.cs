﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Refit;
using System.Text;
using System.Threading.Tasks;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace RefitInternalGenerated
{
    [ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace MarsRoverResearchTool
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    [DebuggerNonUserCode]
    [Preserve]
    partial class AutoGeneratedINasa : INasa        {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedINasa(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<Photos> GetImages(string date)
        {
            var arguments = new object[] { date };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetImages", new Type[] { typeof(string) });
            return (Task<Photos>)func(Client, arguments);
        }

    }
}
