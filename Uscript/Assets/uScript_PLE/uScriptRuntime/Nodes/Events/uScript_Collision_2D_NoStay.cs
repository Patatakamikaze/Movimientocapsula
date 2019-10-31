﻿// uScript uScript_Collision_2D_NoStay.cs
// (C) 2019 Detox Studios LLC

#if !UNITY_3_5 && !UNITY_4_0 && !UNITY_4_1 && !UNITY_4_2
using UnityEngine;
using System.Collections;

[NodePath("Events/Physics Events (2D)")]

[NodeCopyright("Copyright 2019 by Detox Studios LLC")]
[NodeToolTip("Fires an event signal when Instance receives a 2D collision. Does NOT call when an object stays colliding.")]
[NodeAuthor("Detox Studios LLC", "http://www.detoxstudios.com")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("On Collision (2D) - No Stay", "Fires an event signal when Instance GameObject receives a 2D collision. Does NOT call when an object stays colliding (this gives a performance boost over the nodes that DO check). The GameObjects involved must have a 2D rigidbody component on them to fire this event.")]
public class uScript_Collision_2D_NoStay : uScriptEvent
{
    public delegate void uScriptEventHandler(object sender, CollisionEventArgs args);

    public class CollisionEventArgs : System.EventArgs
    {
        private Collision2D m_Collision;

        [FriendlyName("Relative Velocity", "The relative linear velocity of the two colliding GameObjects.")]
        [SocketState(false, false)]
        public Vector2 RelativeVelocity { get { return m_Collision.relativeVelocity; } }

        [FriendlyName("Rigid Body", "The rigidbody component of the 'Triggered By' GameObject that caused this event to fire. This is null if the 'Triggered By' GameObject is a collider with no rigidbody attached.")]
        [SocketState(false, false)]
        public Rigidbody2D RigidBody { get { return m_Collision.rigidbody; } }

        [FriendlyName("Collider", "The collider component of the 'Triggered By' GameObject that casued this event to fire.")]
        [SocketState(false, false)]
        public Collider2D Collider2D { get { return m_Collision.collider; } }

        [FriendlyName("Transform", "The transform component of the 'Triggered By' GameObject that caused this event to fire.")]
        [SocketState(false, false)]
        public Transform Transform { get { return m_Collision.transform; } }

        [FriendlyName("Contact Points", "The contact points generated by the physics engine from the collision.")]
        [SocketState(false, false)]
        public ContactPoint2D[] Contacts { get { return m_Collision.contacts; } }

        [FriendlyName("Triggered By", "The GameObject that collided with this GameObject (the Instance) and caused this event to fire.")]
        public GameObject GameObject { get { return m_Collision.gameObject; } }

        public CollisionEventArgs(Collision2D collision)
        {
            m_Collision = collision;
        }
    }

    [FriendlyName("On Collision Enter")]
    public event uScriptEventHandler OnEnterCollision2D;

    [FriendlyName("On Collision Exit")]
    public event uScriptEventHandler OnExitCollision2D;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (OnEnterCollision2D != null) OnEnterCollision2D(this, new CollisionEventArgs(collision));
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (OnExitCollision2D != null) OnExitCollision2D(this, new CollisionEventArgs(collision));
    }
}

#endif
