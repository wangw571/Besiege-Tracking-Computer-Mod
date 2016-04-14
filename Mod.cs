using System;
using System.Collections;
using System.Collections.Generic;
using spaar.ModLoader;
using TheGuysYouDespise;
using UnityEngine;

namespace Blocks
{
    public class TurretMod : BlockMod
    {
        public override Version Version { get { return new Version("1.0"); } }
        public override string Name { get { return "Turret_Mod"; } }
        public override string DisplayName { get { return "Turret Mod"; } }
        public override string BesiegeVersion { get { return "v0.27"; } }
        public override string Author { get { return "覅是"; } }
        protected Block TurretBlock = new Block()
            ///模块ID
            .ID(525)

            ///模块名称
            .BlockName("Turret Block")

            ///模型信息
            .Obj(new List<Obj> { new Obj("turret.obj", //Obj
                                         "turret.png", //贴图
                                         new VisualOffset(new Vector3(1f, 1f, 1f), //Scale
                                                          new Vector3(0f, 0f, 0f), //Position
                                                          new Vector3(0f, 0f, 0f)))//Rotation
            })

            ///在UI下方的选模块时的模样
            .IconOffset(new Icon(new Vector3(1.30f, 1.30f, 1.30f),  //Scale
                                 new Vector3(-0.11f, -0.13f, 0.00f),  //Position
                                 new Vector3(85f, 90f, 270f))) //Rotation

            ///没啥好说的。
            .Components(new Type[] {
                                    typeof(turret),
            })

            ///给搜索用的关键词
            .Properties(new BlockProperties().SearchKeywords(new string[] {
                                                             "Turret",
                                                             "炮台",
                                                             "War",
                                                             "Weapon"
                                             })
            )
            ///质量
            .Mass(2f)

            ///是否显示碰撞器（在公开你的模块的时候记得写false）
            .ShowCollider(true)

            ///碰撞器
            .CompoundCollider(new List<ColliderComposite> {
                ColliderComposite.Box(new Vector3(0.7f, 0.7f, 1.3f), new Vector3(0f, 0f, 0.8f), new Vector3(0f, 0f, 0f)),
                ColliderComposite.Capsule(0.35f,1.0f,Direction.Z,new Vector3(0,0,0.8f),Vector3.zero),/*
                                ColliderComposite.Sphere(0.49f,                                //radius
                                                         new Vector3(-0.10f, -0.05f, 0.27f),   //Position
                                                         new Vector3(0f, 0f, 0f))              //Rotation
                                                         .IgnoreForGhost(),                    //Do not use this collider on the ghost

                                ColliderComposite.Capsule(0.33f,                               //radius
                                                          1.33f,                               //length
                                                          Direction.Y,                         //direction
                                                          new Vector3(-0.52f, 0.38f, 0.30f),   //position
                                                          new Vector3(5f, 0f, -5f)),           //rotation                                
                                
                                ColliderComposite.Box(new Vector3(0.65f, 0.65f, 0.25f),        //scale
                                                      new Vector3(0f, 0f, 0.25f),              //position
                                                      new Vector3(0f, 0f, 0f)),                //rotation
                                
                                ColliderComposite.Sphere(0.5f,                                  //radius
                                                         new Vector3(-0.10f, -0.05f, 0.35f),    //Position
                                                         new Vector3(0f, 0f, 0f))               //Rotation
                                                         .Trigger().Layer(2)
                                                         .IgnoreForGhost(),                     //Do not use this collider on the ghost
                              //ColliderComposite.Box(new Vector3(0.35f, 0.35f, 0.15f), new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f)).Trigger().Layer(2).IgnoreForGhost(),   <---Example: Box Trigger on specific Layer*/
            })

            ///你的模块是不是可以忽视强搭
            //.IgnoreIntersectionForBase()

            ///载入资源
            .NeededResources(new List<NeededResource> {
                                new NeededResource(ResourceType.Audio,"炮台旋转音效.ogg")
            })

            ///连接点
            .AddingPoints(new List<AddingPoint> {
                               (AddingPoint)new BasePoint(true, true)         //底部连接点。第一个是指你能不能将其他模块安在该模块底部。第二个是指这个点是否是在开局时粘连其他链接点
                                                .Motionable(true,true,true) //底点在X，Y，Z轴上是否是能够活动的。
                                                .SetStickyRadius(0.5f),        //粘连距离
                              new AddingPoint(new Vector3(0f, 0f, 1f), new Vector3(-180f, 00f, 360f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, 0f, 1f), new Vector3(-90f, 00f, 90f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, 0f, 1f), new Vector3(180f, 00f, 180f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, 0f, 1f), new Vector3(90f, 00f, 270f),true).SetStickyRadius(0.3f),


                              new AddingPoint(new Vector3(0f, 0f, 1f), new Vector3(0f, -90f, 90f),true).SetStickyRadius(0.3f),
            });
        protected Block CormacksModifiedTrackingComputer​ = new Block()
            ///模块ID
            .ID(526)

            ///模块名称
            .BlockName("Cormack\'s Modified Tracking Computer​")

            ///模型信息
            .Obj(new List<Obj> { new Obj("turret.obj", //Obj
                                         "Cormack\'s Modified Tracking Computer​.png", //贴图
                                         new VisualOffset(new Vector3(1f, 1f, 1f), //Scale
                                                          new Vector3(0f, 0f, 0f), //Position
                                                          new Vector3(0f, 0f, 0f)))//Rotation
            })

            ///在UI下方的选模块时的模样
            .IconOffset(new Icon(new Vector3(1.30f, 1.30f, 1.30f),  //Scale
                                 new Vector3(-0.11f, -0.13f, 0.00f),  //Position
                                 new Vector3(85f, 90f, 270f))) //Rotation

            ///没啥好说的。
            .Components(new Type[] {
                                    typeof(ModifiedTurret),
            })

            ///给搜索用的关键词
            .Properties(new BlockProperties().SearchKeywords(new string[] {
                                                             "Turret",
                                                             "炮台",
                                                             "War",
                                                             "Weapon"
                                             })
            )
            ///质量
            .Mass(2f)

            ///是否显示碰撞器（在公开你的模块的时候记得写false）
            .ShowCollider(true)

            ///碰撞器
            .CompoundCollider(new List<ColliderComposite> {
                ColliderComposite.Box(new Vector3(0.7f, 0.7f, 1.3f), new Vector3(0f, 0f, 0.8f), new Vector3(0f, 0f, 0f)),
                ColliderComposite.Capsule(0.35f,1.0f,Direction.Z,new Vector3(0,0,0.8f),Vector3.zero),/*
                                ColliderComposite.Sphere(0.49f,                                //radius
                                                         new Vector3(-0.10f, -0.05f, 0.27f),   //Position
                                                         new Vector3(0f, 0f, 0f))              //Rotation
                                                         .IgnoreForGhost(),                    //Do not use this collider on the ghost

                                ColliderComposite.Capsule(0.33f,                               //radius
                                                          1.33f,                               //length
                                                          Direction.Y,                         //direction
                                                          new Vector3(-0.52f, 0.38f, 0.30f),   //position
                                                          new Vector3(5f, 0f, -5f)),           //rotation                                
                                
                                ColliderComposite.Box(new Vector3(0.65f, 0.65f, 0.25f),        //scale
                                                      new Vector3(0f, 0f, 0.25f),              //position
                                                      new Vector3(0f, 0f, 0f)),                //rotation
                                
                                ColliderComposite.Sphere(0.5f,                                  //radius
                                                         new Vector3(-0.10f, -0.05f, 0.35f),    //Position
                                                         new Vector3(0f, 0f, 0f))               //Rotation
                                                         .Trigger().Layer(2)
                                                         .IgnoreForGhost(),                     //Do not use this collider on the ghost
                              //ColliderComposite.Box(new Vector3(0.35f, 0.35f, 0.15f), new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f)).Trigger().Layer(2).IgnoreForGhost(),   <---Example: Box Trigger on specific Layer*/
            })

            ///你的模块是不是可以忽视强搭
            .IgnoreIntersectionForBase()

            ///载入资源
            .NeededResources(new List<NeededResource> {
                                new NeededResource(ResourceType.Audio,"炮台旋转音效.ogg")
            })

            ///连接点
            .AddingPoints(new List<AddingPoint> {
                               (AddingPoint)new BasePoint(true, true)         //底部连接点。第一个是指你能不能将其他模块安在该模块底部。第二个是指这个点是否是在开局时粘连其他链接点
                                                .Motionable(true,true,true) //底点在X，Y，Z轴上是否是能够活动的。
                                                .SetStickyRadius(0.5f),        //粘连距离
                              new AddingPoint(new Vector3(0f, 0f, 1f), new Vector3(-180f, 00f, 360f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, 0f, 1f), new Vector3(-90f, 00f, 90f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, 0f, 1f), new Vector3(180f, 00f, 180f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, 0f, 1f), new Vector3(90f, 00f, 270f),true).SetStickyRadius(0.3f),


                              new AddingPoint(new Vector3(0f, 0f, 1f), new Vector3(0f, -90f, 90f),true).SetStickyRadius(0.3f),
            });

        public override void OnLoad()
        {
            LoadBlock(TurretBlock);//加载该模块
            LoadBlock(CormacksModifiedTrackingComputer);//加载该模块
        }
        public override void OnUnload() { }
    }


    public class turret : BlockScript
    {
        protected MKey Key1;
        protected MSlider 炮力;
        //protected MToggle 不聪明模式;

        private RaycastHit hitt;
        private RaycastHit hitt2;
        private GameObject currentTarget;
        private Vector3 targetPoint;
        private AudioSource Audio;
        private int iterativeCount = 0;
        public float 炮弹速度;
        private float size;
        private float RotatingSpeed = 0.01f;

        public override void SafeAwake()
        {
            Key1 = AddKey("Lock On", //按键信息
                                 "Locked",           //名字
                                 KeyCode.T);       //默认按键

            炮力 = AddSlider("Cannon Slider",       //滑条信息
                                    "CanonPower",       //名字
                                    1f,            //默认值
                                    0f,          //最小值
                                    2f);           //最大值

            /*不聪明模式 = AddToggle("Disable Smart Attack",   //toggle信息
                                       "NoSA",       //名字
                                       false);             //默认状态*/
        }

        protected virtual IEnumerator UpdateMapper()
        {
            if (BlockMapper.CurrentInstance == null)
                yield break;
            while (Input.GetMouseButton(0))
                yield return null;
            BlockMapper.CurrentInstance.Copy();
            BlockMapper.CurrentInstance.Paste();
            yield break;
        }
        public override void OnSave(XDataHolder data)
        {
            SaveMapperValues(data);
        }
        public override void OnLoad(XDataHolder data)
        {
            LoadMapperValues(data);
            if (data.WasSimulationStarted) return;
        }
        protected override void OnSimulateStart()
        {
            currentTarget = null;
            炮弹速度 = 炮力.Value * 60;
            Audio = this.gameObject.AddComponent<AudioSource>();
            Audio.clip = resources["炮台旋转音效.ogg"].audioClip;
            Audio.loop = false;
            Audio.volume = 0.2f;
            this.GetComponent<ConfigurableJoint>().breakForce = Mathf.Infinity;
            this.GetComponent<ConfigurableJoint>().breakTorque = Mathf.Infinity;
            //this.GetComponent<Rigidbody>().angularDrag = 20;
            //this.GetComponent<Rigidbody>().maxAngularVelocity = 2f;
        }
        protected override void OnSimulateUpdate()
        {
            //Trail.GetComponent<TrailRenderer>().material.color = Color.white;
            if (Key1.IsDown)
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitt, float.PositiveInfinity))
                {
                    if (hitt.transform.gameObject != this)
                    {
                        currentTarget = hitt.transform.gameObject;
                    }
                }
            }            
        }

        protected override void OnSimulateFixedUpdate()
        {
            size = 1 * this.transform.localScale.x * this.transform.localScale.y * this.transform.localScale.z;
            this.GetComponent<Rigidbody>().mass = 2f * size;
            if (AddPiece.isSimulating)
            {
                if (currentTarget)
                {
                    if (currentTarget.GetComponent<Rigidbody>())
                    {
                        float targetVelo = currentTarget.GetComponent<Rigidbody>().velocity.magnitude;
                        Vector3 LocalTargetDirection = currentTarget.transform.position;
                        if (炮力.Value != 0)
                        {
                            LocalTargetDirection = calculateNoneLinearTrajectory(
                                炮弹速度,
                                0.2f,
                                this.transform.position,
                                targetVelo,
                                currentTarget.transform.position,
                                currentTarget.transform.forward,
                                    calculateLinearTrajectory(
                                        炮弹速度,
                                        this.transform.position,
                                        targetVelo,
                                        currentTarget.transform.position,
                                        currentTarget.transform.forward
                                    ),
                                    Physics.gravity.y,
                                    size * 0.5f,
                                    float.PositiveInfinity
                                    );
                        }
                        //this.transform.rotation.SetFromToRotation(this.transform.forward, LocalTargetDirection);
                        Vector3 rooo = Vector3.RotateTowards(this.transform.forward, LocalTargetDirection - this.transform.position, RotatingSpeed * size, RotatingSpeed * size);
                        //Debug.Log(LocalTargetDirection + "and" + this.transform.up + "and" + rooo);
                        //this.transform.rotation = Quaternion.LookRotation(rooo);
                        this.GetComponent<Rigidbody>().angularVelocity = (getCorrTorque(this.transform.forward, LocalTargetDirection, this.GetComponent<Rigidbody>(), 0.01f * size) * 360);
                        float mag = (this.transform.forward.normalized - LocalTargetDirection.normalized).magnitude;
                        if (mag > 0.01f)
                        {
                            Audio.volume = mag * 0.2f * Math.Max((10 / (Vector3.Distance(this.transform.position, Camera.main.transform.position))), 1);
                            Audio.Play();
                        }
                        else
                        {
                            Audio.Stop();
                        }
                    }
                }
            }
                    
                }
        Vector2 formulaProjectile(float X, float Y, float V, float G)
        {
            if (G == 0)
            {
                float THETA = Mathf.Atan(Y / X);
                float T = (Y / Mathf.Sin(THETA)) / V;
                return (new Vector2(THETA, T));
            }
            else
            {
                float DELTA = Mathf.Pow(V, 4) - G * (G * X * X - 2 * Y * V * V);
                if (DELTA < 0)
                {
                    return Vector2.zero;
                }
                float THETA1 = Mathf.Atan((-(V * V) + Mathf.Sqrt(DELTA)) / (G * X));
                float THETA2 = Mathf.Atan((-(V * V) - Mathf.Sqrt(DELTA)) / (G * X));
                if (THETA1 > THETA2)
                    THETA1 = THETA2;
                float T = X / (V * Mathf.Cos(THETA1));
                return new Vector2(THETA1, T);
            }
        }

        Vector3 formulaTarget(float VT, Vector3 PT, Vector3 DT, float TT)
        {
            Vector3 newPosition = PT + DT * (VT * TT);
            return newPosition;
        }

        Vector3 calculateNoneLinearTrajectory(float gunVelocity, float AirDrag, Vector3 gunPosition, float aircraftVelocity,Vector3 aircraftPosition, Vector3 aircraftDirection, Vector3 hitPoint, float G, float accuracy, float diff)
        {
            iterativeCount++;
            //if(iterativeCount > 1000) { iterativeCount = 0; return currentTarget.transform.position;  }
            if (hitPoint == Vector3.zero)
            {
                return currentTarget.transform.position;
            }
            Vector3 gunDirection = new Vector3(hitPoint.x, gunPosition.y, hitPoint.z) - gunPosition;
            Quaternion gunRotation = Quaternion.FromToRotation(gunDirection, Vector3.forward);
            Vector3 localHitPoint = gunRotation * (hitPoint - gunPosition);

            float V = gunVelocity;
            float X = localHitPoint.z;//z为前方
            float Y = localHitPoint.y;
            Vector2 TT = formulaProjectile(X, Y, V, G);
            if (TT == Vector2.zero)
            {
                return currentTarget.transform.position;
            }
            float VT = aircraftVelocity;
            Vector3 PT = aircraftPosition;
            Vector3 DT = aircraftDirection;
            float T = TT.y;
            Vector3 newHitPoint = formulaTarget(VT, PT, DT, T);
            float diff1 = (newHitPoint - hitPoint).magnitude;
            if (diff1 > diff)
            {
                return currentTarget.transform.position;
            }
            if (diff1 < accuracy)
            {
                gunRotation = Quaternion.Inverse(gunRotation);
                Y = Mathf.Tan(TT.x) * X;
                newHitPoint = gunRotation * new Vector3(0, Y, X) + gunPosition;
                return newHitPoint;
            }
            return calculateNoneLinearTrajectory(gunVelocity, AirDrag, gunPosition, aircraftVelocity, aircraftPosition, aircraftDirection, newHitPoint, G, accuracy, diff1);
        }
        Vector3 calculateLinearTrajectory(float gunVelocity, Vector3 gunPosition, float aircraftVelocity, Vector3 aircraftPosition, Vector3 aircraftDirection)
        {

            Vector3 hitPoint = Vector3.zero;

            if (aircraftVelocity != 0)
            {
                Vector3 D = gunPosition - aircraftPosition;
                float THETA = Vector3.Angle(D, aircraftDirection) * Mathf.Deg2Rad;
                float DD = D.magnitude;

                float A = 1 - Mathf.Pow((gunVelocity / aircraftVelocity), 2);
                float B = -(2 * DD * Mathf.Cos(THETA));
                float C = DD * DD;
                float DELTA = B * B - 4 * A * C;

                if (DELTA < 0)
                {
                    return Vector3.zero;
                }

                float F1 = (-B + Mathf.Sqrt(B * B - 4 * A * C)) / (2 * A);
                float F2 = (-B - Mathf.Sqrt(B * B - 4 * A * C)) / (2 * A);

                if (F1 < F2)
                    F1 = F2;
                hitPoint = aircraftPosition + aircraftDirection * F1;
            }
            else
            {
                hitPoint = aircraftPosition;
            }
            return hitPoint;
        }
        Vector3 getCorrTorque(Vector3 from, Vector3 to, Rigidbody rb, float SpeedPerSecond)
        {
            Vector3 x = Vector3.Cross(from.normalized, to.normalized);                // axis of rotation
            float theta = Mathf.Asin(x.magnitude);                                    // angle between from & to
            Vector3 w = x.normalized * theta / SpeedPerSecond;                        // scaled angular acceleration
            Vector3 w2 = w - rb.angularVelocity;                                      // need to slow down at a point
            Quaternion q = rb.rotation * rb.inertiaTensorRotation;                    // transform inertia tensor
            return q * Vector3.Scale(rb.inertiaTensor, (Quaternion.Inverse(q) * w2)); // calculate final torque
        }
    }
    public class ModifiedTurret : BlockScript
    {
        protected MKey Key1;
        protected MSlider 炮力;
        //protected MToggle 不聪明模式;

        private RaycastHit hitt;
        private RaycastHit hitt2;
        private GameObject currentTarget;
        private Vector3 targetPoint;
        private AudioSource Audio;
        private int iterativeCount = 0;
        public float 炮弹速度;
        private float size;
        private float RotatingSpeed = 0.01f;

        public override void SafeAwake()
        {
            Key1 = AddKey("Lock On", //按键信息
                                 "Locked",           //名字
                                 KeyCode.T);       //默认按键

            炮力 = AddSlider("Cannon Slider",       //滑条信息
                                    "CanonPower",       //名字
                                    1f,            //默认值
                                    0f,          //最小值
                                    2f);           //最大值

            /*不聪明模式 = AddToggle("Disable Smart Attack",   //toggle信息
                                       "NoSA",       //名字
                                       false);             //默认状态*/
        }

        protected virtual IEnumerator UpdateMapper()
        {
            if (BlockMapper.CurrentInstance == null)
                yield break;
            while (Input.GetMouseButton(0))
                yield return null;
            BlockMapper.CurrentInstance.Copy();
            BlockMapper.CurrentInstance.Paste();
            yield break;
        }
        public override void OnSave(XDataHolder data)
        {
            SaveMapperValues(data);
        }
        public override void OnLoad(XDataHolder data)
        {
            LoadMapperValues(data);
            if (data.WasSimulationStarted) return;
        }
        protected override void OnSimulateStart()
        {
            currentTarget = null;
            炮弹速度 = 炮力.Value * 60;
            Audio = this.gameObject.AddComponent<AudioSource>();
            Audio.clip = resources["炮台旋转音效.ogg"].audioClip;
            Audio.loop = false;
            Audio.volume = 0.2f;
            this.GetComponent<ConfigurableJoint>().breakForce = Mathf.Infinity;
            this.GetComponent<ConfigurableJoint>().breakTorque = Mathf.Infinity;
            //this.GetComponent<Rigidbody>().angularDrag = 20;
            //this.GetComponent<Rigidbody>().maxAngularVelocity = 2f;
        }
        protected override void OnSimulateUpdate()
        {
            //Trail.GetComponent<TrailRenderer>().material.color = Color.white;
            if (Key1.IsDown)
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitt, float.PositiveInfinity))
                {
                    if (hitt.transform.gameObject != this)
                    {
                        currentTarget = hitt.transform.gameObject;
                    }
                }
            }
        }

        protected override void OnSimulateFixedUpdate()
        {
            size = 1 * this.transform.localScale.x * this.transform.localScale.y * this.transform.localScale.z;
            this.GetComponent<Rigidbody>().mass = 2f * size;
            if (AddPiece.isSimulating)
            {
                if (currentTarget)
                {
                    if (currentTarget.GetComponent<Rigidbody>())
                    {
                        float targetVelo = currentTarget.GetComponent<Rigidbody>().velocity.magnitude;
                        Vector3 LocalTargetDirection = currentTarget.transform.position;
                        if (炮力.Value != 0)
                        {
                            LocalTargetDirection = calculateNoneLinearTrajectory(
                                炮弹速度,
                                0.2f,
                                this.transform.position,
                                targetVelo,
                                currentTarget.transform.position,
                                currentTarget.transform.forward,
                                    calculateLinearTrajectory(
                                        炮弹速度,
                                        this.transform.position,
                                        targetVelo,
                                        currentTarget.transform.position,
                                        currentTarget.transform.forward
                                    ),
                                    Physics.gravity.y,
                                    size * 0.5f,
                                    float.PositiveInfinity
                                    );
                        }
                        //this.transform.rotation.SetFromToRotation(this.transform.forward, LocalTargetDirection);
                        Vector3 rooo = Vector3.RotateTowards(this.transform.right, LocalTargetDirection - this.transform.position, RotatingSpeed * size, RotatingSpeed * size);
                        //Debug.Log(LocalTargetDirection + "and" + this.transform.up + "and" + rooo);
                        //this.transform.rotation = Quaternion.LookRotation(rooo);
                        this.GetComponent<Rigidbody>().angularVelocity = (getCorrTorque(this.transform.right, LocalTargetDirection, this.GetComponent<Rigidbody>(), 0.01f * size) * 360);
                        float mag = (this.transform.right.normalized - LocalTargetDirection.normalized).magnitude;
                        if (mag > 0.01f)
                        {
                            Audio.volume = mag * 0.2f * Math.Max((10 / (Vector3.Distance(this.transform.position, Camera.main.transform.position))), 1);
                            Audio.Play();
                        }
                        else
                        {
                            Audio.Stop();
                        }
                    }
                }
            }

        }
        Vector2 formulaProjectile(float X, float Y, float V, float G)
        {
            if (G == 0)
            {
                float THETA = Mathf.Atan(Y / X);
                float T = (Y / Mathf.Sin(THETA)) / V;
                return (new Vector2(THETA, T));
            }
            else
            {
                float DELTA = Mathf.Pow(V, 4) - G * (G * X * X - 2 * Y * V * V);
                if (DELTA < 0)
                {
                    return Vector2.zero;
                }
                float THETA1 = Mathf.Atan((-(V * V) + Mathf.Sqrt(DELTA)) / (G * X));
                float THETA2 = Mathf.Atan((-(V * V) - Mathf.Sqrt(DELTA)) / (G * X));
                if (THETA1 > THETA2)
                    THETA1 = THETA2;
                float T = X / (V * Mathf.Cos(THETA1));
                return new Vector2(THETA1, T);
            }
        }

        Vector3 formulaTarget(float VT, Vector3 PT, Vector3 DT, float TT)
        {
            Vector3 newPosition = PT + DT * (VT * TT);
            return newPosition;
        }

        Vector3 calculateNoneLinearTrajectory(float gunVelocity, float AirDrag, Vector3 gunPosition, float aircraftVelocity, Vector3 aircraftPosition, Vector3 aircraftDirection, Vector3 hitPoint, float G, float accuracy, float diff)
        {
            iterativeCount++;
            //if (iterativeCount > 1000) { iterativeCount = 0; return currentTarget.transform.position; }
            if (hitPoint == Vector3.zero)
            {
                return currentTarget.transform.position;
            }
            Vector3 gunDirection = new Vector3(hitPoint.x, gunPosition.y, hitPoint.z) - gunPosition;
            Quaternion gunRotation = Quaternion.FromToRotation(gunDirection, Vector3.forward);
            Vector3 localHitPoint = gunRotation * (hitPoint - gunPosition);

            float V = gunVelocity;
            float X = localHitPoint.z;//z为前方
            float Y = localHitPoint.y;
            Vector2 TT = formulaProjectile(X, Y, V, G);
            if (TT == Vector2.zero)
            {
                return currentTarget.transform.position;
            }
            float VT = aircraftVelocity;
            Vector3 PT = aircraftPosition;
            Vector3 DT = aircraftDirection;
            float T = TT.y;
            Vector3 newHitPoint = formulaTarget(VT, PT, DT, T);
            float diff1 = (newHitPoint - hitPoint).magnitude;
            if (diff1 > diff)
            {
                return currentTarget.transform.position;
            }
            if (diff1 < accuracy)
            {
                gunRotation = Quaternion.Inverse(gunRotation);
                Y = Mathf.Tan(TT.x) * X;
                newHitPoint = gunRotation * new Vector3(0, Y, X) + gunPosition;
                return newHitPoint;
            }
            return calculateNoneLinearTrajectory(gunVelocity, AirDrag, gunPosition, aircraftVelocity, aircraftPosition, aircraftDirection, newHitPoint, G, accuracy, diff1);
        }
        Vector3 calculateLinearTrajectory(float gunVelocity, Vector3 gunPosition, float aircraftVelocity, Vector3 aircraftPosition, Vector3 aircraftDirection)
        {

            Vector3 hitPoint = Vector3.zero;

            if (aircraftVelocity != 0)
            {
                Vector3 D = gunPosition - aircraftPosition;
                float THETA = Vector3.Angle(D, aircraftDirection) * Mathf.Deg2Rad;
                float DD = D.magnitude;

                float A = 1 - Mathf.Pow((gunVelocity / aircraftVelocity), 2);
                float B = -(2 * DD * Mathf.Cos(THETA));
                float C = DD * DD;
                float DELTA = B * B - 4 * A * C;

                if (DELTA < 0)
                {
                    return Vector3.zero;
                }

                float F1 = (-B + Mathf.Sqrt(B * B - 4 * A * C)) / (2 * A);
                float F2 = (-B - Mathf.Sqrt(B * B - 4 * A * C)) / (2 * A);

                if (F1 < F2)
                    F1 = F2;
                hitPoint = aircraftPosition + aircraftDirection * F1;
            }
            else
            {
                hitPoint = aircraftPosition;
            }
            return hitPoint;
        }
        Vector3 getCorrTorque(Vector3 from, Vector3 to, Rigidbody rb, float SpeedPerSecond)
        {
            Vector3 x = Vector3.Cross(from.normalized, to.normalized);                // axis of rotation
            float theta = Mathf.Asin(x.magnitude);                                    // angle between from & to
            Vector3 w = x.normalized * theta / SpeedPerSecond;                        // scaled angular acceleration
            Vector3 w2 = w - rb.angularVelocity;                                      // need to slow down at a point
            Quaternion q = rb.rotation * rb.inertiaTensorRotation;                    // transform inertia tensor
            return q * Vector3.Scale(rb.inertiaTensor, (Quaternion.Inverse(q) * w2)); // calculate final torque
        }
    }
    //Physics stuff
}
    

    
