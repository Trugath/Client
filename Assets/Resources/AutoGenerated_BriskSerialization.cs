// #### AUTO-GENERATED CODE ####
// Please avoid editing
// Copyright © Brisk Technologies

namespace Brisk.Serialization {
    public sealed class AutoGenerated_BriskSerialization : Brisk.Serialization.Serializer {
        private static readonly System.Collections.Generic.Dictionary<System.Type, System.Action<Brisk.Entities.NetBehaviour,Lidgren.Network.NetOutgoingMessage>> serializersReliable = 
          new System.Collections.Generic.Dictionary<System.Type, System.Action<Brisk.Entities.NetBehaviour,Lidgren.Network.NetOutgoingMessage>> {

        };
        public override void SerializeReliable<T>(T obj, Lidgren.Network.NetOutgoingMessage msg) {
            if (serializersReliable.ContainsKey(obj.GetType())) serializersReliable[obj.GetType()](obj, msg);
        }
        private static readonly System.Collections.Generic.Dictionary<System.Type, System.Action<Brisk.Entities.NetBehaviour,Lidgren.Network.NetIncomingMessage>> deserializersReliable = 
          new System.Collections.Generic.Dictionary<System.Type, System.Action<Brisk.Entities.NetBehaviour,Lidgren.Network.NetIncomingMessage>> {

        };
        public override void DeserializeReliable<T>(T obj, Lidgren.Network.NetIncomingMessage msg) {
            if (deserializersReliable.ContainsKey(obj.GetType())) deserializersReliable[obj.GetType()](obj, msg);
        }
        private static readonly System.Collections.Generic.Dictionary<System.Type, System.Action<Brisk.Entities.NetBehaviour,Lidgren.Network.NetOutgoingMessage>> serializersUnreliable = 
          new System.Collections.Generic.Dictionary<System.Type, System.Action<Brisk.Entities.NetBehaviour,Lidgren.Network.NetOutgoingMessage>> {
            {typeof(Brisk.Entities.NetEntity), (bhr, msg) => {
                var obj = (Brisk.Entities.NetEntity)bhr;
                msg.Write(obj.Position.x);
                msg.Write(obj.Position.y);
                msg.Write(obj.Position.z);
                msg.Write(obj.Rotation.x);
                msg.Write(obj.Rotation.y);
                msg.Write(obj.Rotation.z);
                }
            },
        };
        public override void SerializeUnreliable<T>(T obj, Lidgren.Network.NetOutgoingMessage msg) {
            if (serializersUnreliable.ContainsKey(obj.GetType())) serializersUnreliable[obj.GetType()](obj, msg);
        }
        private static readonly System.Collections.Generic.Dictionary<System.Type, System.Action<Brisk.Entities.NetBehaviour,Lidgren.Network.NetIncomingMessage>> deserializersUnreliable = 
          new System.Collections.Generic.Dictionary<System.Type, System.Action<Brisk.Entities.NetBehaviour,Lidgren.Network.NetIncomingMessage>> {
            {typeof(Brisk.Entities.NetEntity), (bhr, msg) => {
                var obj = (Brisk.Entities.NetEntity)bhr;
                obj.Position = new UnityEngine.Vector3(msg.ReadFloat(), msg.ReadFloat(), msg.ReadFloat());
                obj.Rotation = new UnityEngine.Vector3(msg.ReadFloat(), msg.ReadFloat(), msg.ReadFloat());
                }
            },
        };
        public override void DeserializeUnreliable<T>(T obj, Lidgren.Network.NetIncomingMessage msg) {
            if (deserializersUnreliable.ContainsKey(obj.GetType())) deserializersUnreliable[obj.GetType()](obj, msg);
        }
    }
}
