/// <auto-generated />
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace MagicOnion
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::MagicOnion;
    using global::MagicOnion.Client;

    public static partial class MagicOnionInitializer
    {
        static bool isRegistered = false;

        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Register()
        {
            if(isRegistered) return;
            isRegistered = true;

            MagicOnionClientRegistry<global::ChatApp.Shared.Services.IChatService>.Register((x, y) => new ChatApp.Shared.Services.ChatServiceClient(x, y));

            StreamingHubClientRegistry<global::ChatApp.Shared.Hubs.IChatHub, global::ChatApp.Shared.Hubs.IChatHubReceiver>.Register((a, _, b, c, d, e) => new ChatApp.Shared.Hubs.ChatHubClient(a, b, c, d, e));
        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace MagicOnion.Resolvers
{
    using System;
    using MessagePack;

    public class MagicOnionResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new MagicOnionResolver();

        MagicOnionResolver()
        {

        }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> formatter;

            static FormatterCache()
            {
                var f = MagicOnionResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }

    internal static class MagicOnionResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static MagicOnionResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(3)
            {
                {typeof(global::MagicOnion.DynamicArgumentTuple<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>), 0 },
                {typeof(global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>), 1 },
                {typeof(global::System.Collections.Generic.List<global::System.Int32>), 2 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key))
            {
                return null;
            }

            switch (key)
            {
                case 0: return new global::MagicOnion.DynamicArgumentTupleFormatter<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>(default(global::System.Collections.Generic.List<global::System.Int32>), default(global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>));
                case 1: return new global::MessagePack.Formatters.DictionaryFormatter<global::System.Int32, global::System.String>();
                case 2: return new global::MessagePack.Formatters.ListFormatter<global::System.Int32>();
                default: return null;
            }
        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618
/// <auto-generated />
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace ChatApp.Shared.Services
{
    using global::System;
    using global::Grpc.Core;
    using global::MagicOnion;
    using global::MagicOnion.Client;
    using global::MessagePack;
    
    [global::MagicOnion.Ignore]
    public class ChatServiceClient : global::MagicOnion.Client.MagicOnionClientBase<global::ChatApp.Shared.Services.IChatService>, global::ChatApp.Shared.Services.IChatService
    {
        class ClientCore
        {
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::System.String, global::MessagePack.Nil> GenerateException;
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::System.String, global::MessagePack.Nil> SendReportAsync;
            public ClientCore(global::MagicOnion.IMagicOnionMessageSerializer messageSerializer)
            {
                this.GenerateException = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_RefType_ValueType<global::System.String, global::MessagePack.Nil>(global::Grpc.Core.MethodType.Unary, "IChatService", "GenerateException", messageSerializer);
                this.SendReportAsync = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_RefType_ValueType<global::System.String, global::MessagePack.Nil>(global::Grpc.Core.MethodType.Unary, "IChatService", "SendReportAsync", messageSerializer);
            }
        }
        
        readonly ClientCore core;
        
        public ChatServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, global::MagicOnion.IMagicOnionMessageSerializer messageSerializer) : base(options)
        {
            this.core = new ClientCore(messageSerializer);
        }
        
        private ChatServiceClient(MagicOnionClientOptions options, ClientCore core) : base(options)
        {
            this.core = core;
        }
        
        protected override global::MagicOnion.Client.MagicOnionClientBase<IChatService> Clone(global::MagicOnion.Client.MagicOnionClientOptions options)
            => new ChatServiceClient(options, core);
        
        public global::MagicOnion.UnaryResult<global::MessagePack.Nil> GenerateException(global::System.String message)
            => this.core.GenerateException.InvokeUnary(this, "IChatService/GenerateException", message);
        public global::MagicOnion.UnaryResult<global::MessagePack.Nil> SendReportAsync(global::System.String message)
            => this.core.SendReportAsync.InvokeUnary(this, "IChatService/SendReportAsync", message);
    }
}


/// <auto-generated />
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace ChatApp.Shared.Hubs
{
    using global::System;
    using global::Grpc.Core;
    using global::MagicOnion;
    using global::MagicOnion.Client;
    using global::MessagePack;
    
    [global::MagicOnion.Ignore]
    public class ChatHubClient : global::MagicOnion.Client.StreamingHubClientBase<global::ChatApp.Shared.Hubs.IChatHub, global::ChatApp.Shared.Hubs.IChatHubReceiver>, global::ChatApp.Shared.Hubs.IChatHub
    {
        protected override global::Grpc.Core.Method<global::System.Byte[], global::System.Byte[]> DuplexStreamingAsyncMethod { get; }
        
        public ChatHubClient(global::Grpc.Core.CallInvoker callInvoker, global::System.String host, global::Grpc.Core.CallOptions options, global::MagicOnion.IMagicOnionMessageSerializer messageSerializer, global::MagicOnion.Client.IMagicOnionClientLogger logger)
            : base(callInvoker, host, options, messageSerializer, logger)
        {
            var marshaller = global::MagicOnion.MagicOnionMarshallers.ThroughMarshaller;
            DuplexStreamingAsyncMethod = new global::Grpc.Core.Method<global::System.Byte[], global::System.Byte[]>(global::Grpc.Core.MethodType.DuplexStreaming, "IChatHub", "Connect", marshaller, marshaller);
        }
        
        public global::System.Threading.Tasks.Task JoinAsync(global::ChatApp.Shared.MessagePackObjects.JoinRequest request)
            => base.WriteMessageWithResponseAsync<global::ChatApp.Shared.MessagePackObjects.JoinRequest, global::MessagePack.Nil>(-733403293, request);
        public global::System.Threading.Tasks.Task LeaveAsync()
            => base.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(1368362116, global::MessagePack.Nil.Default);
        public global::System.Threading.Tasks.Task SendMessageAsync(global::System.String message)
            => base.WriteMessageWithResponseAsync<global::System.String, global::MessagePack.Nil>(-601690414, message);
        public global::System.Threading.Tasks.Task GenerateException(global::System.String message)
            => base.WriteMessageWithResponseAsync<global::System.String, global::MessagePack.Nil>(517938971, message);
        public global::System.Threading.Tasks.Task SampleMethod(global::System.Collections.Generic.List<global::System.Int32> sampleList, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String> sampleDictionary)
            => base.WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>, global::MessagePack.Nil>(-852153394, new global::MagicOnion.DynamicArgumentTuple<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>(sampleList, sampleDictionary));
        
        public global::ChatApp.Shared.Hubs.IChatHub FireAndForget()
            => new FireAndForgetClient(this);
        
        [global::MagicOnion.Ignore]
        class FireAndForgetClient : global::ChatApp.Shared.Hubs.IChatHub
        {
            readonly ChatHubClient parent;
        
            public FireAndForgetClient(ChatHubClient parent)
                => this.parent = parent;
        
            public global::ChatApp.Shared.Hubs.IChatHub FireAndForget() => this;
            public global::System.Threading.Tasks.Task DisposeAsync() => throw new global::System.NotSupportedException();
            public global::System.Threading.Tasks.Task WaitForDisconnect() => throw new global::System.NotSupportedException();
        
            public global::System.Threading.Tasks.Task JoinAsync(global::ChatApp.Shared.MessagePackObjects.JoinRequest request)
                => parent.WriteMessageFireAndForgetAsync<global::ChatApp.Shared.MessagePackObjects.JoinRequest, global::MessagePack.Nil>(-733403293, request);
            public global::System.Threading.Tasks.Task LeaveAsync()
                => parent.WriteMessageFireAndForgetAsync<global::MessagePack.Nil, global::MessagePack.Nil>(1368362116, global::MessagePack.Nil.Default);
            public global::System.Threading.Tasks.Task SendMessageAsync(global::System.String message)
                => parent.WriteMessageFireAndForgetAsync<global::System.String, global::MessagePack.Nil>(-601690414, message);
            public global::System.Threading.Tasks.Task GenerateException(global::System.String message)
                => parent.WriteMessageFireAndForgetAsync<global::System.String, global::MessagePack.Nil>(517938971, message);
            public global::System.Threading.Tasks.Task SampleMethod(global::System.Collections.Generic.List<global::System.Int32> sampleList, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String> sampleDictionary)
                => parent.WriteMessageFireAndForgetAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>, global::MessagePack.Nil>(-852153394, new global::MagicOnion.DynamicArgumentTuple<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>(sampleList, sampleDictionary));
            
        }
        
        protected override void OnBroadcastEvent(global::System.Int32 methodId, global::System.ArraySegment<global::System.Byte> data)
        {
            switch (methodId)
            {
                case -1297457280: // Void OnJoin(global::System.String name)
                    {
                        var value = base.Deserialize<global::System.String>(data);
                        receiver.OnJoin(value);
                    }
                    break;
                case 532410095: // Void OnLeave(global::System.String name)
                    {
                        var value = base.Deserialize<global::System.String>(data);
                        receiver.OnLeave(value);
                    }
                    break;
                case -552695459: // Void OnSendMessage(global::ChatApp.Shared.MessagePackObjects.MessageResponse message)
                    {
                        var value = base.Deserialize<global::ChatApp.Shared.MessagePackObjects.MessageResponse>(data);
                        receiver.OnSendMessage(value);
                    }
                    break;
            }
        }
        
        protected override void OnResponseEvent(global::System.Int32 methodId, global::System.Object taskCompletionSource, global::System.ArraySegment<global::System.Byte> data)
        {
            switch (methodId)
            {
                case -733403293: // Task JoinAsync(global::ChatApp.Shared.MessagePackObjects.JoinRequest request)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case 1368362116: // Task LeaveAsync()
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case -601690414: // Task SendMessageAsync(global::System.String message)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case 517938971: // Task GenerateException(global::System.String message)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case -852153394: // Task SampleMethod(global::System.Collections.Generic.List<global::System.Int32> sampleList, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String> sampleDictionary)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
            }
        }
        
    }
}


