// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: max.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Max {
  public static partial class FindMaxService
  {
    static readonly string __ServiceName = "max.FindMaxService";

    static readonly grpc::Marshaller<global::Max.FindMaxRequest> __Marshaller_max_FindMaxRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Max.FindMaxRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Max.FindMaxResponse> __Marshaller_max_FindMaxResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Max.FindMaxResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Max.FindMaxRequest, global::Max.FindMaxResponse> __Method_findMaximum = new grpc::Method<global::Max.FindMaxRequest, global::Max.FindMaxResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "findMaximum",
        __Marshaller_max_FindMaxRequest,
        __Marshaller_max_FindMaxResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Max.MaxReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FindMaxService</summary>
    [grpc::BindServiceMethod(typeof(FindMaxService), "BindService")]
    public abstract partial class FindMaxServiceBase
    {
      public virtual global::System.Threading.Tasks.Task findMaximum(grpc::IAsyncStreamReader<global::Max.FindMaxRequest> requestStream, grpc::IServerStreamWriter<global::Max.FindMaxResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FindMaxService</summary>
    public partial class FindMaxServiceClient : grpc::ClientBase<FindMaxServiceClient>
    {
      /// <summary>Creates a new client for FindMaxService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FindMaxServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FindMaxService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FindMaxServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FindMaxServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FindMaxServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::Max.FindMaxRequest, global::Max.FindMaxResponse> findMaximum(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return findMaximum(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Max.FindMaxRequest, global::Max.FindMaxResponse> findMaximum(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_findMaximum, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override FindMaxServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FindMaxServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(FindMaxServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_findMaximum, serviceImpl.findMaximum).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FindMaxServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_findMaximum, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Max.FindMaxRequest, global::Max.FindMaxResponse>(serviceImpl.findMaximum));
    }

  }
}
#endregion