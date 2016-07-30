using System;
using System.Collections;
using System.Collections.Generic;
using spaar.ModLoader;
using TheGuysYouDespise;
using UnityEngine;

namespace Blocks
{
    public class TrackingComputerMod : BlockMod
    {
        public override Version Version { get { return new Version("2.5"); } }
        public override string Name { get { return "Tracking_Computer_Mod"; } }
        public override string DisplayName { get { return "Tracking Computer Mod"; } }
        public override string BesiegeVersion { get { return "v0.3"; } }
        public override string Author { get { return "覅是"; } }
        protected Block TurretBlock = new Block()
            ///模块ID
            .ID(525)

            ///模块名称
            .BlockName("Tracking Computer I")

            ///模型信息
            .Obj(new List<Obj> { new Obj("turret.obj", //Obj
                                         "turret.png", //贴图 
                                         new VisualOffset(new Vector3(1f, 1f, 1f), //Scale
                                                          new Vector3(0f, 0f, 0f), //Position
                                                          new Vector3(-90f, 0f, 0f)))//Rotation
            })

            ///在UI下方的选模块时的模样
            .IconOffset(new Icon(new Vector3(1f, 1f, 1f),  //Scale
                                 new Vector3(-0.11f, -0.13f, 0.00f),  //Position
                                 new Vector3(350f, 150f, 250f))) //Rotation

            ///没啥好说的。
            .Components(new Type[] {
                                    typeof(TrackingComputer),
            })

            ///给搜索用的关键词
            .Properties(new BlockProperties().SearchKeywords(new string[] {
                                                             "Turret",
                                                             "炮台",
                                                             "导弹",
                                                             "War",
                                                             "Weapon"
                                             }).Burnable(3)
            )
            ///质量
            .Mass(2f)

            ///是否显示碰撞器（在公开你的模块的时候记得写false）
            .ShowCollider(false)

            ///碰撞器
            .CompoundCollider(new List<ColliderComposite> {
                ColliderComposite.Box(new Vector3(1f, 1f, 1.2f), new Vector3(0f, 0f, 0.6f), new Vector3(0f, 0f, 0f)),
                //ColliderComposite.Capsule(0.35f,1.0f,Direction.Z,new Vector3(0,0,0.8f),Vector3.zero),
                /*
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
                                new NeededResource(ResourceType.Audio,"炮台旋转音效.ogg"),
                                new NeededResource(ResourceType.Mesh,"MissileModule.obj"),
                                new NeededResource(ResourceType.Mesh,"turret.obj")
            })

            ///连接点
            .AddingPoints(new List<AddingPoint> {
                               (AddingPoint)new BasePoint(true, true)         //底部连接点。第一个是指你能不能将其他模块安在该模块底部。第二个是指这个点是否是在开局时粘连其他链接点
                                                .Motionable(true,true,true) //底点在X，Y，Z轴上是否是能够活动的。
                                                .SetStickyRadius(0.5f),        //粘连距离
                              new AddingPoint(new Vector3(0f, 0f, 0.65f), new Vector3(-180f, 00f, 360f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, 0f, 0.65f), new Vector3(-90f, 00f, 90f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, 0f, 0.65f), new Vector3(180f, 00f, 180f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, 0f, 0.65f), new Vector3(90f, 00f, 270f),true).SetStickyRadius(0.3f),


                              new AddingPoint(new Vector3(0f, 0f, 0.7f), new Vector3(0f, -90f, 90f),true).SetStickyRadius(0.3f),
            });
        protected Block CormacksModifiedTrackingComputer​ = new Block()
            ///模块ID
            .ID(526)

            ///模块名称
            .BlockName("Cormack\'s Modified Tracking Computer​"/*"科尔马克氏改良型索敌计算机"*/)

            ///模型信息
            .Obj(new List<Obj> { new Obj("turret.obj", //Obj
                                         "Cormack\'s Modified Tracking Computer​.png", //贴图
                                         new VisualOffset(new Vector3(1f, 1f, 1f), //Scale
                                                          new Vector3(-0.6f, 0f, 0.5f), //Position
                                                          new Vector3(90f, -90f, 0f)))//Rotation
            })

            ///在UI下方的选模块时的模样
            .IconOffset(new Icon(Vector3.one,  //Scale
                                 new Vector3(-0.11f, -0.13f, 0.00f),  //Position
                                 new Vector3(350f, 150f, 250f))) //Rotation

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
                                             }).Burnable(7)
            )
            ///质量
            .Mass(2f)

            ///是否显示碰撞器（在公开你的模块的时候记得写false）
            .ShowCollider(false)

            ///碰撞器
            .CompoundCollider(new List<ColliderComposite> {
                ColliderComposite.Box(new Vector3(1f, 1.3f, 1f), new Vector3(0f, 0f, 0.5f), new Vector3(0f, 0f, 0f)),
                //ColliderComposite.Capsule(0.35f,1.0f,Direction.Z,new Vector3(0,0,0.8f),Vector3.zero),
                /*
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
                              new AddingPoint(new Vector3(0f, 0.2f, 0.5f), new Vector3(-180f, 00f, 360f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0.05f, 0f, 0.5f), new Vector3(-90f, 00f, 90f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, -0.2f, 0.5f), new Vector3(180f, 00f, 180f),true).SetStickyRadius(0.3f),
                              new AddingPoint(new Vector3(0f, 0f, 0.5f), new Vector3(90f, 00f, 270f),true).SetStickyRadius(0.3f),


                              new AddingPoint(new Vector3(0f, 0f, 0.6f), new Vector3(0f, -90f, 90f),true).SetStickyRadius(0.3f),
            });

        public override void OnLoad()
        {
            LoadBlock(TurretBlock);//加载该模块
            LoadBlock(CormacksModifiedTrackingComputer);//加载该模块
        }
        public override void OnUnload() { }
    }


    public class TrackingComputer : BlockScript
    {
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
            if (iterativeCount > 512) { iterativeCount = 0; return hitPoint; }
            if (hitPoint == Vector3.zero || gunVelocity < 1)
            {
                return currentTarget.transform.position;
            }
            Vector3 gunDirection = new Vector3(hitPoint.x, gunPosition.y, hitPoint.z) - gunPosition;
            Quaternion gunRotation = Quaternion.FromToRotation(gunDirection, Vector3.forward);
            Vector3 localHitPoint = gunRotation * (hitPoint - gunPosition);
            float currentCalculatedDistance = (hitPoint - gunPosition).magnitude;

            float b2M4ac = gunVelocity * gunVelocity - 2 * AirDrag * currentCalculatedDistance;
            if (b2M4ac < 0) { /*Debug.Log("Nan!!!" + (gunVelocity * gunVelocity - 2 * AirDrag * currentCalculatedDistance));*/ return currentTarget.transform.position;  }
            float V = (float)Math.Sqrt(b2M4ac);
            float X = localHitPoint.z;//z为前方
            float Y = localHitPoint.y;
            Vector2 TT = formulaProjectile(X, Y, V, G);
            if (TT == Vector2.zero)
            {
                iterativeCount = 0;
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
                iterativeCount = 0;
                return currentTarget.transform.position;
            }
            if (diff1 < accuracy)
            {
                gunRotation = Quaternion.Inverse(gunRotation);
                Y = Mathf.Tan(TT.x) * X;
                newHitPoint = gunRotation * new Vector3(0, Y, X) + gunPosition;
                iterativeCount = 0;
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
            try
            {
                Vector3 x = Vector3.Cross(from.normalized, to.normalized);                // axis of rotation
                float theta = Mathf.Asin(x.magnitude);                                    // angle between from & to
                Vector3 w = x.normalized * theta / SpeedPerSecond;                        // scaled angular acceleration
                Vector3 w2 = w - rb.angularVelocity;                                      // need to slow down at a point
                Quaternion q = rb.rotation * rb.inertiaTensorRotation;                    // transform inertia tensor
                return q * Vector3.Scale(rb.inertiaTensor, (Quaternion.Inverse(q) * w2)); // calculate final torque
            }
            catch { return Vector3.zero; }
        }

        protected MKey Key1;
        protected MKey Key2;
        protected MSlider 炮力;
        protected MSlider 精度;
        protected MSlider 计算间隔;
        protected MMenu 模式;
        protected MMenu MissileGuidanceMode;
        protected MKey MissileGuidanceModeSwitchButton;
        protected MSlider MissileHeightController;
        //protected MToggle 不聪明模式;

        private RaycastHit hitt;
        private RaycastHit hitt2;
        private bool IHaveConnectedWithCannons = false;
        private bool IsOverLoaded = false;
        private GameObject currentTarget;
        private Vector3 targetPoint;
        private AudioSource Audio;
        private int iterativeCount = 0;
        public float 炮弹速度;
        public Vector3 前一帧速度;
        private float size;
        private float RotatingSpeed = 4f;
        public float 记录器 = 0;
        public Vector3 默认朝向;
        public Transform 只有一门炮也是没有问题的;
        public bool 但是有两门炮 = false;

        public int MissileGuidanceModeInt;
        //public float MaxAcceleration = 0;



        public override void SafeAwake()
        {
             Key1 = AddKey("Lock On", //按键信息
                                  "Locked",           //名字
                                  KeyCode.T);       //默认按键

             Key2 = AddKey("Release Lock", //按键信息2
                                  "RLocked",           //名字
                                  KeyCode.Slash);       //默认按键
             List<string> chaos = new List<String> { "Turret Tracking \nComputer", "Missile Guidance \nComputer", "Camera Tracking \nComputer" };
             模式 = AddMenu("Mode", 0, chaos);

             炮力 = AddSlider("Cannon Slider",       //滑条信息
                                     "CanonPower",       //名字
                                     1f,            //默认值
                                     0f,          //最小值
                                     2f);           //最大值

             精度 = AddSlider("Precision",       //滑条信息
                                     "Precision",       //名字
                                     0.5f,            //默认值
                                     0.01f,          //最小值
                                     10f);           //最大值

             计算间隔 = AddSlider("Calculation per second",       //滑条信息 
                                     "CalculationPerSecond",       //名字
                                     100f,            //默认值
                                     1f,          //最小值
                                     100f);           //最大值

             MissileGuidanceMode = AddMenu("MissileMode", 0, new List<string> { "Calculate \nTarget Speed", "Directly Follow", "From Top", "From Bottom"});

             MissileGuidanceModeSwitchButton = AddKey("Switch Guide Mode", "GuideModeSwitch", KeyCode.RightControl);

             MissileHeightController = AddSlider("Height above target", "Height", 100, 0, 1500);

            /*Key1 = AddKey("获取目标", //按键信息
                                 "Locked",           //名字
                                 KeyCode.T);       //默认按键

            Key2 = AddKey("解除锁定", //按键信息2
                                 "RLocked",           //名字
                                 KeyCode.Slash);       //默认按键
            List<string> chaos = new List<String> { "炮塔索敌计算机", "导弹导引计算机", "相机跟踪计算机" };
            模式 = AddMenu("Mode", 0, chaos);

            炮力 = AddSlider("炮力",       //滑条信息
                                    "CanonPower",       //名字
                                    1f,            //默认值
                                    0f,          //最小值
                                    2f);           //最大值

            精度 = AddSlider("精度",       //滑条信息
                                    "Precision",       //名字
                                    0.5f,            //默认值
                                    0.01f,          //最小值
                                    10f);           //最大值

            计算间隔 = AddSlider("每秒计算频率",       //滑条信息 
                                    "CalculationPerSecond",       //名字
                                    100f,            //默认值
                                    1f,          //最小值
                                    100f);           //最大值

            MissileGuidanceMode = AddMenu("MissileMode", 0, new List<string> { "预测目标运动", "直接跟随", "攻顶", "攻底" });

            MissileGuidanceModeSwitchButton = AddKey("切换导引模式", "GuideModeSwitch", KeyCode.RightControl);

            MissileHeightController = AddSlider("目标上方高度", "Height", 100, 0, 1500);
            */
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

        protected override void BuildingUpdate()
        {
            炮力.DisplayInMapper = 模式.Value == 0;
            计算间隔.DisplayInMapper = 模式.Value == 0 || 模式.Value == 1;
            精度.DisplayInMapper = 模式.Value == 0 || 模式.Value == 1;
            MissileGuidanceMode.DisplayInMapper = 模式.Value == 1;
            MissileGuidanceModeSwitchButton.DisplayInMapper = 模式.Value == 1;

            if(MissileGuidanceMode.Value == 2)
            {
                MissileHeightController.DisplayInMapper = true;
                MissileHeightController.DisplayName = "目标上方高度";
            }
            else if (MissileGuidanceMode.Value == 3)
            {
                MissileHeightController.DisplayInMapper = true;
                MissileHeightController.DisplayName = "高度";
            }
            else
            {
                MissileHeightController.DisplayInMapper = false;
            }
            MissileGuidanceModeInt = MissileGuidanceMode.Value;
            ModelReplacer();
            MissileColorApplier();
        }
        protected override void OnSimulateStart()
        {
            currentTarget = null;
            炮弹速度 = 炮力.Value * 58;
            MissileGuidanceModeInt = MissileGuidanceMode.Value;
            Audio = this.gameObject.AddComponent<AudioSource>();
            Audio.clip = resources["炮台旋转音效.ogg"].audioClip;
            Audio.loop = false;
            Audio.volume = 0.2f;
            ConfigurableJoint conf = this.GetComponent<ConfigurableJoint>();
            conf.breakForce = Mathf.Infinity;
            conf.breakTorque = Mathf.Infinity;
            conf.angularZMotion = ConfigurableJointMotion.Locked;
            try
            {
                默认朝向 = this.transform.forward;
            }
            catch { 默认朝向 = Vector3.zero; }

            ModelReplacer();
            MissileColorApplier();

            //this.GetComponent<Rigidbody>().angularDrag = 20;
            //this.GetComponent<Rigidbody>().maxAngularVelocity = 2f;
        }
        protected override void OnSimulateUpdate()
        {
            //Trail.GetComponent<TrailRenderer>().material.color = Color.white;
            if (Key1.IsPressed && !HasBurnedOut())
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitt, float.PositiveInfinity))
                {
                    if (hitt.transform.position != this.transform.position && !hitt.transform.tag.Contains("Cloaked"))
                    {
                        currentTarget = hitt.transform.gameObject;
                    }
                }
            }

            if (Key2.IsPressed)
            {
                currentTarget = null;
            }
            if(MissileGuidanceModeSwitchButton.IsPressed && currentTarget == null)
            {
                MissileGuidanceMode.Value++;
                if(MissileGuidanceMode.Value > MissileGuidanceMode.Items.Count - 1) { MissileGuidanceMode.Value = 0; }
                MissileGuidanceModeInt = MissileGuidanceMode.Value;
            }
            MissileColorApplier();

            if (HasBurnedOut())
            {
                currentTarget = null;
            }

            if (模式.Value == 2)
            {
                CameraTrackingComputerMode();
            }
            else if (模式.Value == 0 && !IHaveConnectedWithCannons)
            {
                IHaveConnectedWithCannons = false;
                foreach (Joint Jo in this.GetComponent<GenericBlock>().jointsToMe)
                {
                    if (Jo.GetComponentInParent<CanonBlock>())
                    {
                        CanonBlock cb = Jo.GetComponentInParent<CanonBlock>();
                        if (!IsOverLoaded)
                        {
                            cb.knockbackSpeed = 4250;
                        } 
                        else { cb.knockbackSpeed = 8000; }
                        IHaveConnectedWithCannons = true;
                        if (jointsToMe.Count == 1)
                        {
                            只有一门炮也是没有问题的 = cb.transform;
                        }
                    }
                    但是有两门炮 = 只有一门炮也是没有问题的 == null;
                    
                }
            }
            
        }
        protected override void OnSimulateFixedUpdate()
        {
            if (HasBurnedOut()) return;
            if (currentTarget)
                if (currentTarget.GetComponentInParent<MachineTrackerMyId>())
                {
                    if (currentTarget.GetComponentInParent<MachineTrackerMyId>().gameObject.name.Contains("IsCloaked") || this.name.Contains(("IsCloaked")))
                        currentTarget = null;
                }
                else if (currentTarget.gameObject.name == "FieldDetector")
                {
                    foreach (Transform block in Machine.Active().SimulationMachine)
                    {
                        if (block.name.Contains("Improved") && (block.position - currentTarget.transform.position).sqrMagnitude < 1)
                            currentTarget = block.gameObject;
                    }
                }

            if (!IsOverLoaded)
            {
                bool aha;
                    aha = ((前一帧速度 - this.rigidbody.velocity).sqrMagnitude >= 25f && 模式.Value == 0 && !IHaveConnectedWithCannons) 
                    || 
                    (IHaveConnectedWithCannons && (前一帧速度 - this.rigidbody.velocity).sqrMagnitude >= 12500f && 模式.Value == 0)
                    || 
                    (模式.Value == 1 && (前一帧速度 - this.rigidbody.velocity).sqrMagnitude >= 200f)
                    ;
                if(aha)
                {
                    OverLoadExplosion();
                    this.GetComponent<FireTag>().Ignite();
                    IsOverLoaded = true;
                }
                /*else
                {
                    MaxAcceleration = Math.Max(MaxAcceleration, (前一帧速度 - this.rigidbody.velocity).sqrMagnitude);
                    Debug.Log(MaxAcceleration);
                }*/
            }
            else
            {
                Debug.Log("Overloaded! Tracking Computer CPU Damaged!");
            }

            if (模式.Value == 0 && !IsOverLoaded)
            {
                TurretTrackingComputerMode();
            }
            else if (模式.Value == 1 && !IsOverLoaded)
            {
                MissileGuidanceComputerMode();
            }
            
        }
        void TurretTrackingComputerMode()
        {
            size = 1 * this.transform.localScale.x * this.transform.localScale.y * this.transform.localScale.z;
            this.GetComponent<Rigidbody>().mass = 2f * size;
            float FireProg = this.GetComponentInChildren<FireController>().fireProgress;
            if (AddPiece.isSimulating)
            {
                if(只有一门炮也是没有问题的 && !但是有两门炮)
                {
                    炮弹速度 = 只有一门炮也是没有问题的.GetComponent<BlockBehaviour>().Sliders[0].Value * 55;
                }
                记录器 += (计算间隔.Value / 100) * (1 - FireProg);
                Vector3 LocalTargetDirection = this.transform.position + 默认朝向 * 2;

                if (currentTarget)
                {
                    if (currentTarget.GetComponent<Rigidbody>() && currentTarget.transform.position != this.transform.position)
                    {
                        LocalTargetDirection = currentTarget.transform.position;
                        if (炮力.Value != 0 && 记录器 >= 1)
                        {
                            float targetVelo = currentTarget.GetComponent<Rigidbody>().velocity.magnitude;
                            记录器 = 0;
                            LocalTargetDirection = calculateNoneLinearTrajectory(
                                炮弹速度,
                                0.2f,
                                this.transform.position,
                                targetVelo,
                                currentTarget.transform.position,
                                currentTarget.GetComponent<Rigidbody>().velocity.normalized,
                                    calculateLinearTrajectory(
                                        炮弹速度,
                                        this.transform.position,
                                        targetVelo,
                                        currentTarget.transform.position,
                                        currentTarget.GetComponent<Rigidbody>().velocity.normalized
                                    ),
                                    Physics.gravity.y,
                                    size * 精度.Value + 10 * size * FireProg,
                                    float.PositiveInfinity
                                    );
                        }
                    }
                }
                //this.transform.rotation.SetFromToRotation(this.transform.forward, LocalTargetDirection);
                Vector3 rooo = Vector3.RotateTowards(this.transform.forward, LocalTargetDirection - this.transform.position, RotatingSpeed * size, RotatingSpeed * size);
                //Debug.Log(LocalTargetDirection + "and" + this.transform.up + "and" + rooo);
                //this.transform.rotation = Quaternion.LookRotation(rooo);
                //LocalTargetDirection = new Vector3(LocalTargetDirection.x, LocalTargetDirection.y - this.transform.position.y, LocalTargetDirection.z);
                float Difference = Vector3.Angle(transform.forward, LocalTargetDirection - this.transform.position * 1);
                Vector3 calculated;
                if (Difference > 精度.Value)
                {
                    calculated = (getCorrTorque(this.transform.forward, LocalTargetDirection - this.transform.position * 1, this.GetComponent<Rigidbody>(), 0.01f * size) * Mathf.Rad2Deg).normalized * RotatingSpeed;
                }
                else
                {
                    calculated = (getCorrTorque(this.transform.forward, LocalTargetDirection - this.transform.position * 1, this.GetComponent<Rigidbody>(), 0.01f * size) * Mathf.Rad2Deg);
                }
                    this.GetComponent<Rigidbody>().angularVelocity = calculated;
                float mag = (this.transform.forward.normalized - LocalTargetDirection.normalized).magnitude;
                //Debug.Log(Vector3.Angle(transform.forward, LocalTargetDirection - this.transform.position * 1));
                if (Vector3.Angle(transform.forward, LocalTargetDirection - this.transform.position * 1) > 精度.Value * 0.01f)
                {
                    //this.GetComponent<Rigidbody>().freezeRotation = false;
                    Audio.volume = mag * 0.2f * Math.Max((10 / (Vector3.Distance(this.transform.position, GameObject.Find("Main Camera").transform.position))), 1);
                    Audio.Play();
                }
                else
                {
                    //if (炮力.Value != 0) this.GetComponent<Rigidbody>().freezeRotation = true;
                    Audio.Stop();
                }
                前一帧速度 = this.rigidbody.velocity;
            }
        }
        void MissileGuidanceComputerMode()
        {
            size = 1 * this.transform.localScale.x * this.transform.localScale.y * this.transform.localScale.z;
            this.GetComponent<Rigidbody>().mass = 2f * size;

            /*if (this.GetComponent<ConfigurableJoint>())
            {
                this.GetComponent<ConfigurableJoint>().angularXMotion = ConfigurableJointMotion.Locked;
                this.GetComponent<ConfigurableJoint>().angularYMotion = ConfigurableJointMotion.Locked;
                this.GetComponent<ConfigurableJoint>().angularZMotion = ConfigurableJointMotion.Locked;
            }*/

            this.GetComponentInChildren<BoxCollider>().size = new Vector3(0.7f, 0.7f, 1.3f);
            this.GetComponentInChildren<BoxCollider>().center = new Vector3(0f, 0f, 0.8f);

            float FireProg = this.GetComponentInChildren<FireController>().fireProgress;
            记录器 += (计算间隔.Value / 100) * (1 - FireProg);
            if (currentTarget)
            {
                if (currentTarget.GetComponent<Rigidbody>() && currentTarget.transform.position != this.transform.position)
                {
                    Vector3 LocalTargetDirection = currentTarget.transform.position;
                    if (MissileGuidanceModeInt == 2)
                    {
                        Vector2 HorizontalDistance = new Vector2(currentTarget.transform.position.x - this.transform.position.x, currentTarget.transform.position.z - this.transform.position.z);
                        if (this.transform.position.y > currentTarget.transform.position.y + MissileHeightController.Value)
                        {
                            LocalTargetDirection = currentTarget.transform.position + new Vector3(HorizontalDistance.x / (this.rigidbody.velocity.x + 0.0001f), currentTarget.transform.position.y + MissileHeightController.Value * 1.1f, HorizontalDistance.y / (this.rigidbody.velocity.z + 0.0001f));
                        }
                        else
                        {
                            LocalTargetDirection = this.transform.position + Vector3.up * (currentTarget.transform.position.y + MissileHeightController.Value * 1.1f);
                        }
                            //Debug.Log(HorizontalDistance);
                        if (HorizontalDistance.sqrMagnitude < 100 * 炮弹速度)
                        {
                            MissileGuidanceModeInt = 0;
                        }
                    }
                    else if (MissileGuidanceModeInt == 3)
                    {
                        Vector2 HorizontalDistance = new Vector2(currentTarget.transform.position.x - this.transform.position.x, currentTarget.transform.position.z - this.transform.position.z);
                        if(this.transform.position.y < MissileHeightController.Value)
                        {
                            LocalTargetDirection = new Vector3(transform.position.x,MissileHeightController.Value * 1.5f,transform.position.z);
                        }
                        else if(this.transform.position.y > MissileHeightController.Value * 2)
                        {
                            LocalTargetDirection = new Vector3(transform.position.x + HorizontalDistance.normalized.x * 1.5f, MissileHeightController.Value, transform.position.z + +HorizontalDistance.normalized.y);
                        }
                        else
                        {
                            LocalTargetDirection = currentTarget.transform.position + new Vector3(HorizontalDistance.x / (this.rigidbody.velocity.x + 0.0001f), MissileHeightController.Value * 1f, HorizontalDistance.y / (this.rigidbody.velocity.z + 0.0001f));
                        }

                        if (HorizontalDistance.sqrMagnitude < 100 * 炮弹速度)
                        {
                            MissileGuidanceModeInt = 0;
                        }
                    }
                    else
                    {
                        if (MissileGuidanceModeInt == 0)
                        {
                            LocalTargetDirection = currentTarget.transform.position;
                            LocalTargetDirection = MissileMode0(LocalTargetDirection, FireProg);
                        }
                    }
                    //this.transform.rotation.SetFromToRotation(this.transform.forward, LocalTargetDirection);
                    //Vector3 rooo = Vector3.RotateTowards(this.transform.forward, LocalTargetDirection - this.transform.position, RotatingSpeed * size, RotatingSpeed * size);
                    //Debug.Log(LocalTargetDirection + "and" + this.transform.up + "and" + rooo);
                    //this.transform.rotation = Quaternion.LookRotation(rooo);
                    //LocalTargetDirection = new Vector3(LocalTargetDirection.x, LocalTargetDirection.y - this.transform.position.y, LocalTargetDirection.z);
                    //float mag = (LocalTargetDirection.normalized - transform.forward.normalized).magnitude;
                    Vector3 TargetDirection = (getCorrTorque(this.transform.forward, LocalTargetDirection - this.transform.position * 1, this.GetComponent<Rigidbody>(), 0.01f * size * Mathf.Rad2Deg).normalized);
                    if (Vector3.Angle(transform.forward, LocalTargetDirection - this.transform.position * 1) < 105 || MissileGuidanceMode.Value != 0 || MissileGuidanceMode.Value != 1)
                    {
                        this.GetComponent<Rigidbody>().angularVelocity = (TargetDirection * RotatingSpeed * 4);
                    }
                    else { Debug.Log("Target Lost!"); }
                }
            }
                前一帧速度 = this.GetComponent<Rigidbody>().velocity;
        }
        void CameraTrackingComputerMode()
        {
            if (AddPiece.isSimulating)
            {
                if (currentTarget)
                {
                    this.transform.LookAt(currentTarget.transform.position);
                    try
                    {
                        this.GetComponent<Rigidbody>().mass = 0.00001f;
                    }
                    catch { }
                }
            }
        }

        Vector3 MissileMode0 (Vector3 LocalTargetDirection,float FireProg)
        {
            if (记录器 >= 1)
            {
                炮弹速度 = this.GetComponent<Rigidbody>().velocity.magnitude;
                float targetVelo = currentTarget.GetComponent<Rigidbody>().velocity.magnitude;
                记录器 = 0;
                //Debug.Log((currentTarget.GetComponent<Rigidbody>().velocity - 前一帧速度).magnitude);
                LocalTargetDirection = calculateNoneLinearTrajectory(
                    炮弹速度 + 0.001f,
                    (this.GetComponent<Rigidbody>().velocity - 前一帧速度).magnitude,
                    this.transform.position,
                    targetVelo,
                    currentTarget.transform.position,
                    currentTarget.GetComponent<Rigidbody>().velocity.normalized,
                        calculateLinearTrajectory(
                            炮弹速度,
                            this.transform.position,
                            targetVelo,
                            currentTarget.transform.position,
                            currentTarget.GetComponent<Rigidbody>().velocity.normalized
                        ),
                        Physics.gravity.y,
                        size * 精度.Value + 10 * size * FireProg,
                        float.PositiveInfinity
                        );
            }
            if(LocalTargetDirection.y == float.NaN)
            {
                LocalTargetDirection = currentTarget.transform.position;
            }
            前一帧速度 = this.GetComponent<Rigidbody>().velocity;
            return LocalTargetDirection;
        }

        void MissileColorApplier()
        {
            Transform Vis = transform.Find("Vis/Vis");
            if (MissileGuidanceModeInt == 0)
            {
                Vis.GetComponent<MeshRenderer>().material.color = Color.white;
            }
            else if (MissileGuidanceModeInt == 1)
            {
                Vis.GetComponent<MeshRenderer>().material.color = Color.black;
            }
            else if (MissileGuidanceModeInt == 2)
            {
                Vis.GetComponent<MeshRenderer>().material.color = Color.Lerp(Color.red,Color.white,0.5f);
            }
            else if (MissileGuidanceModeInt == 3)
            {
                Vis.GetComponent<MeshRenderer>().material.color = Color.yellow;
            }
        }
        void ModelReplacer()
        {
            Transform Vis = transform.Find("Vis/Vis");
            if (模式.Value == 1)
            {
                Vis.GetComponentInChildren<MeshFilter>().mesh = resources["MissileModule.obj"].mesh;
                Vis.GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                MissileColorApplier();
                this.GetComponentInChildren<BoxCollider>().size = new Vector3(0.7f, 0.7f, 1.3f);
                this.GetComponentInChildren<BoxCollider>().center = new Vector3(0f, 0f, 0.8f);
            }
            else
            {
                Vis.GetComponentInChildren<MeshFilter>().mesh = resources["turret.obj"].mesh;
                Vis.GetComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                MissileColorApplier();
                this.GetComponentInChildren<BoxCollider>().size = new Vector3(1f, 1f, 1.2f);
                this.GetComponentInChildren<BoxCollider>().center = new Vector3(0f, 0f, 0.6f);
            }
        }
        void OverLoadExplosion()
        {
            GameObject explo = (GameObject)GameObject.Instantiate(PrefabMaster.BlockPrefabs[59].gameObject, this.transform.position, this.transform.rotation);
            explo.transform.localScale = Vector3.one * 0.01f;
            TimedRocket ac = explo.GetComponent<TimedRocket>();
            ac.SetSlip(Color.white);
            ac.radius = 0.00001f;
            ac.power = 0.00001f;
            ac.randomDelay = 0.000001f;
            ac.upPower = 0;
            ac.StartCoroutine(ac.Explode(0.01f));
            explo.AddComponent<TimedSelfDestruct>();
        }
    }
    public class ModifiedTurret : BlockScript
    {
        protected MKey Key1;
        protected MKey Key2;
        protected MSlider 炮力;
        protected MSlider 精度;
        protected MSlider 计算间隔;
        protected MSlider 模块id;
        protected MSlider 镜头哪里;
        protected MToggle 是否使用;
        protected MToggle FireOnMouseClick;
        protected MMenu 模式;
        protected MToggle 不聪明模式;
        protected MToggle DisableHTracking;
        protected MToggle DisableVTracking;
        protected MSlider KnockBackBonusAdjuster;
        protected MToggle LockConnectionWhenNoTarget;

        private RaycastHit hitt;
        private RaycastHit hitt2;
        private GameObject currentTarget;
        private Vector3 targetPoint;
        private AudioSource Audio;
        private int iterativeCount = 0;
        public float 炮弹速度;
        private float size;
        private float RotatingSpeed = 8f;
        public float 记录器 = 0;

        public Vector3 前一帧速度 = Vector3.zero;
        private bool IHaveConnectedWithCannons = false;
        private bool IsOverLoaded = false;

        public override void SafeAwake()
        {
            Key1 = AddKey("Lock On", //按键信息
                                 "Locked",           //名字
                                 KeyCode.T);       //默认按键

            Key2 = AddKey("Release Lock", //按键信息2
                                 "RLocked",           //名字
                                 KeyCode.Slash);       //默认按键

            炮力 = AddSlider("Cannon Slider",       //滑条信息
                                    "CanonPower",       //名字
                                    1f,            //默认值
                                    0f,          //最小值
                                    2f);           //最大值

            精度 = AddSlider("Precision",       //滑条信息
                                    "Precision",       //名字
                                    0.5f,            //默认值
                                    0.01f,          //最小值
                                    20f);           //最大值

            计算间隔 = AddSlider("Calculation per second",       //滑条信息
                                    "CalculationPerSecond",       //名字
                                    100f,            //默认值
                                    0.01f,          //最小值
                                    100f);           //最大值

            模块id = AddSlider("First Target to lock",       //滑条信息
                                    "FirstTarget",       //名字
                                    2f,            //默认值
                                    0f,          //最小值
                                    60f);           //最大值

            镜头哪里 = AddSlider("Distance From Camera", "Dist", 1500, 1, 900000);

            是否使用 = AddToggle("Use First Target \nTo Lock Function", "USE", false);
            模式 = AddMenu("Menu", 0, new List<string> { "Lock Mode", "Mouse Mode" });

            不聪明模式 = AddToggle("Disable Calculation",   //toggle信息
                                       "NoCL",       //名字
                                       false);             //默认状态

            FireOnMouseClick = AddToggle("Fire On Click", "FOC", true);

            //DisableHTracking = AddToggle("Disable Horizontal Tracking", "DHT", false);
            DisableVTracking = AddToggle("Disable Vertical Tracking", "DVT", false);

            KnockBackBonusAdjuster = AddSlider("Knockback/Overload Adjust", "ADJ", 95, 0, 95);

            LockConnectionWhenNoTarget = AddToggle("Lock the connection\nwhen having no target", "LOCKConnection", false);

            /*Key1 = AddKey("获取目标", //按键信息
                                 "Locked",           //名字
                                 KeyCode.T);       //默认按键

            Key2 = AddKey("解除锁定", //按键信息2
                                 "RLocked",           //名字
                                 KeyCode.Slash);       //默认按键

            炮力 = AddSlider("炮力",       //滑条信息
                                    "CanonPower",       //名字
                                    1f,            //默认值
                                    0f,          //最小值
                                    2f);           //最大值

            精度 = AddSlider("精度",       //滑条信息
                                    "Precision",       //名字
                                    0.5f,            //默认值
                                    0.01f,          //最小值
                                    10f);           //最大值

            计算间隔 = AddSlider("每秒计算频率",       //滑条信息 
                                    "CalculationPerSecond",       //名字
                                    100f,            //默认值
                                    1f,          //最小值
                                    100f);           //最大值

            模块id = AddSlider("开局就锁定的模块",       //滑条信息
                                    "FirstTarget",       //名字
                                    2f,            //默认值
                                    0f,          //最小值
                                    60f);           //最大值

            镜头哪里 = AddSlider("距离相机的距离", "Dist", 1500, 1, 900000);

            是否使用 = AddToggle("启用\n开局锁定模块\n功能", "USE", false);
            模式 = AddMenu("Menu", 0, new List<string> { "锁定模式", "跟随鼠标模式" });

            不聪明模式 = AddToggle("不计算弹道",   //toggle信息
                                       "NoCL",       //名字
                                       false);             //默认状态

            FireOnMouseClick = AddToggle("在鼠标点击时开火", "FOC", true);

            //DisableHTracking = AddToggle("Disable Horizontal Tracking", "DHT", false);
            DisableVTracking = AddToggle("关闭垂直方向的计算", "DVT", false);

            KnockBackBonusAdjuster = AddSlider("后坐力/过载 调整", "ADJ", 95, 0, 95);

            LockConnectionWhenNoTarget = AddToggle("当没有目标时\n锁定连接点", "LOCKConnection", false);*/
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
        protected override void BuildingUpdate()
        {
            是否使用.DisplayInMapper = 模式.Value == 0;

            Key1.DisplayInMapper = 模式.Value != 1;
            Key2.DisplayInMapper = 模式.Value != 1;

            KnockBackBonusAdjuster.Value = Mathf.Clamp(KnockBackBonusAdjuster.Value, 0, 95);

            模块id.DisplayInMapper = 是否使用.IsActive && 模式.Value == 0;

            镜头哪里.DisplayInMapper = 模式.Value == 1;
            不聪明模式.DisplayInMapper = 模式.Value == 1;
            计算间隔.DisplayInMapper = !(不聪明模式.IsActive && 模式.Value == 1);
            精度.DisplayInMapper = !(不聪明模式.IsActive && 模式.Value == 1);
            炮力.DisplayInMapper = !(不聪明模式.IsActive && 模式.Value == 1);

            FireOnMouseClick.DisplayInMapper = 模式.Value == 1;
        }
        protected override void OnSimulateStart()
        {
            currentTarget = null;
            炮弹速度 = 炮力.Value * 58;
            Audio = this.gameObject.AddComponent<AudioSource>();
            Audio.clip = resources["炮台旋转音效.ogg"].audioClip;
            Audio.loop = false;
            Audio.volume = 0.2f;
            ConfigurableJoint conf = this.GetComponent<ConfigurableJoint>();
            conf.breakForce = Mathf.Infinity;
            conf.breakTorque = Mathf.Infinity;
            conf.angularZMotion = ConfigurableJointMotion.Locked;
            if (是否使用.IsActive)
            {
                GameObject furthestTarget = null;
                foreach (Transform FirstTarget in Machine.Active().SimulationMachine)
                {
                    if (FirstTarget.GetComponent<MachineTrackerMyId>().myId == (int)模块id.Value)
                    {
                        try
                        {
                            if (this.transform.InverseTransformPoint(furthestTarget.transform.position).sqrMagnitude < this.transform.InverseTransformPoint(FirstTarget.transform.position).sqrMagnitude)
                            {
                                furthestTarget = FirstTarget.gameObject;
                            }
                        }
                        catch { furthestTarget = FirstTarget.gameObject; }
                    }
                }
                if (furthestTarget != null) currentTarget = furthestTarget;
            }
            //this.GetComponent<Rigidbody>().angularDrag = 20;
            //this.GetComponent<Rigidbody>().maxAngularVelocity = 2f;
        }
        protected override void OnSimulateUpdate()
        {
            /*if (Input.GetKey("1"))
            {
                this.GetComponent<ConfigurableJoint>().angularXMotion = ConfigurableJointMotion.Locked;
            }
            else
            {
                this.GetComponent<ConfigurableJoint>().angularXMotion = ConfigurableJointMotion.Free;
            }
            if (Input.GetKey("2"))
            {
                this.GetComponent<ConfigurableJoint>().angularYMotion = ConfigurableJointMotion.Locked;
            }
            else
            {
                this.GetComponent<ConfigurableJoint>().angularYMotion = ConfigurableJointMotion.Free;
            }
            if (Input.GetKey("3"))
            {
                this.GetComponent<ConfigurableJoint>().angularZMotion = ConfigurableJointMotion.Locked;
            }
            else
            {
                this.GetComponent<ConfigurableJoint>().angularZMotion = ConfigurableJointMotion.Free;
            }*/

            //Trail.GetComponent<TrailRenderer>().material.color = Color.white;
            if (Key1.IsPressed && !HasBurnedOut() && 模式.Value == 0)
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitt, float.PositiveInfinity))
                {
                    if (hitt.transform.position != this.transform.position)
                    {
                        currentTarget = hitt.transform.gameObject;
                    }
                }
            }

            if (Key2.IsPressed && 模式.Value == 0)
            {
                currentTarget = null;
            }

            if (HasBurnedOut())
            {
                currentTarget = null;
            }

            if (模式.Value == 1 && !不聪明模式.IsActive)
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitt, float.PositiveInfinity))
                {
                    if (hitt.transform.position != this.transform.position)
                    {
                        currentTarget = hitt.transform.gameObject;
                    }
                }
            }
            foreach (Joint Jo in this.GetComponent<GenericBlock>().jointsToMe)
            {
                IHaveConnectedWithCannons = false;
                if(Jo.GetComponentInParent<CanonBlock>())
                {
                    CanonBlock cb = Jo.GetComponentInParent<CanonBlock>();
                    if (!IsOverLoaded)
                    {
                        cb.knockbackSpeed = 8000 * ((100 - KnockBackBonusAdjuster.Value) / 100);
                        cb.randomDelay = 0.000001f;
                    }
                    else { cb.knockbackSpeed = 8000; }
                    if (FireOnMouseClick.IsActive && 模式.Value == 1 && Input.GetMouseButtonDown(0)) { cb.Shoot(); }
                    IHaveConnectedWithCannons = true;
                }
            }
        }

        protected override void OnSimulateFixedUpdate()
        {
            size = 1 * this.transform.localScale.x * this.transform.localScale.y * this.transform.localScale.z;
            this.GetComponent<Rigidbody>().mass = 2f * size;
            float FireProg = this.GetComponentInChildren<FireController>().fireProgress;
            if (currentTarget)
            {
                if (currentTarget.GetComponentInParent<MachineTrackerMyId>())
                {
                    if (currentTarget.GetComponentInParent<MachineTrackerMyId>().gameObject.name.Contains("IsCloaked") || this.name.Contains(("IsCloaked")))
                        currentTarget = null;
                }
                else if (currentTarget.gameObject.name == "FieldDetector")
                {
                    foreach (Transform block in Machine.Active().SimulationMachine)
                    {
                        if (block.name.Contains("Improved") && (block.position - currentTarget.transform.position).sqrMagnitude < 1)
                            currentTarget = block.gameObject;
                    }
                }

                if (LockConnectionWhenNoTarget.IsActive)
                {
                    this.GetComponent<ConfigurableJoint>().angularXMotion = ConfigurableJointMotion.Free;
                    this.GetComponent<ConfigurableJoint>().angularYMotion = ConfigurableJointMotion.Free;
                }
            }
            else if(LockConnectionWhenNoTarget.IsActive)
            {
                this.GetComponent<ConfigurableJoint>().angularXMotion = ConfigurableJointMotion.Locked;
                this.GetComponent<ConfigurableJoint>().angularYMotion = ConfigurableJointMotion.Locked;
            }

            if (AddPiece.isSimulating && !HasBurnedOut())
            {
                记录器 += (计算间隔.Value / 100) * (1 - FireProg);
                if (currentTarget?.GetComponent<Rigidbody>())
                {
                    NonMouseMode(FireProg);
                }
                else if (模式.Value == 1 && !HasBurnedOut())
                {
                    MouseMode(FireProg);
                }
            }

            if (!IsOverLoaded)
            {
                IsOverLoaded = 
                    ((前一帧速度 - this.GetComponent<Rigidbody>().velocity).sqrMagnitude >= 25f && 模式.Value == 0 && !IHaveConnectedWithCannons)
                    ||
                    (IHaveConnectedWithCannons && (前一帧速度 - this.rigidbody.velocity).sqrMagnitude >= 12500f * (Mathf.Log(97 - KnockBackBonusAdjuster.Value,2)) && 模式.Value == 0)
                    ;
                if(IsOverLoaded)
                {
                    OverLoadExplosion();
                    this.GetComponent<FireTag>().Ignite();
                }
            }
            else
            {
                Debug.Log("Overloaded!");
            }
            前一帧速度 = this.GetComponent<Rigidbody>().velocity;

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
            if (iterativeCount > 512) { iterativeCount = 0; return hitPoint; }
            if (hitPoint == Vector3.zero || hitPoint == gunPosition)
            {
                return aircraftPosition;
            }
            Vector3 gunDirection = new Vector3(hitPoint.x, gunPosition.y, hitPoint.z) - gunPosition;
            Quaternion gunRotation = Quaternion.FromToRotation(gunDirection, Vector3.forward);
            Vector3 localHitPoint = gunRotation * (hitPoint - gunPosition);
            float currentCalculatedDistance = (hitPoint - gunPosition).magnitude;

            float V = (float)Math.Sqrt(gunVelocity * gunVelocity - 2 * AirDrag * currentCalculatedDistance);
            float X = localHitPoint.z;//z为前方
            float Y = localHitPoint.y;
            Vector2 TT = formulaProjectile(X, Y, V, G);
            if (TT == Vector2.zero)
            {
                iterativeCount = 0;
                return aircraftPosition;
            }
            float VT = aircraftVelocity;
            Vector3 PT = aircraftPosition;
            Vector3 DT = aircraftDirection;
            float T = TT.y;
            Vector3 newHitPoint = formulaTarget(VT, PT, DT, T);
            float diff1 = (newHitPoint - hitPoint).magnitude;
            if (diff1 > diff)
            {
                iterativeCount = 0;
                return aircraftPosition;
            }
            if (diff1 < accuracy)
            {
                gunRotation = Quaternion.Inverse(gunRotation);
                Y = Mathf.Tan(TT.x) * X;
                newHitPoint = gunRotation * new Vector3(0, Y, X) + gunPosition;
                iterativeCount = 0;
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
            try
            {
                Vector3 x = Vector3.Cross(from.normalized, to.normalized);                // axis of rotation
                float theta = Mathf.Asin(x.magnitude);                                    // angle between from & to
                Vector3 w = x.normalized * theta / SpeedPerSecond;                        // scaled angular acceleration
                Vector3 w2 = w - rb.angularVelocity;                                      // need to slow down at a point
                Quaternion q = rb.rotation * rb.inertiaTensorRotation;                    // transform inertia tensor
                return q * Vector3.Scale(rb.inertiaTensor, (Quaternion.Inverse(q) * w2)); // calculate final torque
            }
            catch { return Vector3.zero; }
        }

        void NonMouseMode(float FireProg)
        {

            if (currentTarget.transform.position != this.transform.position)
            {
                Vector3 LocalTargetDirection = currentTarget.transform.position;
                if (炮力.Value != 0 && 记录器 >= 1)
                {
                    float targetVelo = currentTarget.GetComponent<Rigidbody>().velocity.magnitude;
                    记录器 = 0;
                    LocalTargetDirection = calculateNoneLinearTrajectory(
                        炮弹速度,
                        0.2f,
                        this.transform.position,
                        targetVelo,
                        currentTarget.transform.position,
                        currentTarget.GetComponent<Rigidbody>().velocity.normalized,
                            calculateLinearTrajectory(
                                炮弹速度,
                                this.transform.position,
                                targetVelo,
                                currentTarget.transform.position,
                                currentTarget.GetComponent<Rigidbody>().velocity.normalized
                            ),
                            Physics.gravity.y,
                            size * 精度.Value + 10 * size * FireProg,
                            float.PositiveInfinity
                            );
                }
                //this.transform.rotation.SetFromToRotation(this.transform.right, LocalTargetDirection);
                Vector3 rooo = Vector3.RotateTowards(this.transform.right, LocalTargetDirection - this.transform.position, RotatingSpeed * size, RotatingSpeed * size);
                //Debug.Log(LocalTargetDirection + "and" + this.transform.up + "and" + rooo);
                //this.transform.rotation = Quaternion.LookRotation(rooo);
                //LocalTargetDirection = new Vector3(LocalTargetDirection.x, LocalTargetDirection.y - this.transform.position.y, LocalTargetDirection.z);
                /*if(DisableHTracking.IsActive)
                {
                    LocalTargetDirection = new Vector3(this.transform.right.x, LocalTargetDirection.y, this.transform.right.z);
                }*/
                if(DisableVTracking.IsActive)
                {
                    LocalTargetDirection = new Vector3(LocalTargetDirection.x, this.transform.right.y, LocalTargetDirection.z);
                }
                float Difference = Vector3.Angle(transform.forward, LocalTargetDirection - this.transform.position * 1);
                if (Difference > 精度.Value)
                {
                    this.GetComponent<Rigidbody>().angularVelocity = (getCorrTorque(this.transform.right, LocalTargetDirection - this.transform.position * 1, this.GetComponent<Rigidbody>(), 0.01f * size) * Mathf.Rad2Deg).normalized * RotatingSpeed;
                }
                else
                {
                    this.GetComponent<Rigidbody>().angularVelocity = (getCorrTorque(this.transform.right, LocalTargetDirection - this.transform.position * 1, this.GetComponent<Rigidbody>(), 0.01f * size) * Mathf.Rad2Deg);
                }
                    //this.GetComponent<Rigidbody>().angularVelocity = (getCorrTorque(this.transform.right, LocalTargetDirection - this.transform.position * 1, this.GetComponent<Rigidbody>(), 0.01f * size) * Mathf.Rad2Deg).normalized * RotatingSpeed;
                float mag = (this.transform.right.normalized - LocalTargetDirection.normalized).magnitude;
                if (Vector3.Angle(transform.right, LocalTargetDirection - this.transform.position * 1) > 0.01f * 精度.Value)
                {
                    this.GetComponent<Rigidbody>().freezeRotation = false;
                    Audio.volume = mag * 0.2f * Math.Max((10 / (Vector3.Distance(this.transform.position, GameObject.Find("Main Camera").transform.position))), 1);
                    Audio.Play();
                }
                else
                {
                    this.GetComponent<Rigidbody>().freezeRotation = true;
                    Audio.Stop();
                }
            }
        }
        void MouseMode(float FireProg)
        {
            Vector3 AimPos = GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 镜头哪里.Value));
            if (AimPos != this.transform.position)
            {
                Vector3 LocalTargetDirection = AimPos;
                if (炮力.Value != 0 && 记录器 >= 1 && !不聪明模式.IsActive)
                {
                    记录器 = 0;
                    LocalTargetDirection = calculateNoneLinearTrajectory(
                        炮弹速度,
                        0.2f,
                        this.transform.position,
                        0,
                        AimPos,
                        Vector3.zero,
                            AimPos,
                            Physics.gravity.y,
                            size * 精度.Value + 10 * size * FireProg,
                            float.PositiveInfinity
                            );
                }
                //this.transform.rotation.SetFromToRotation(this.transform.right, LocalTargetDirection);
                Vector3 rooo = Vector3.RotateTowards(this.transform.right, LocalTargetDirection - this.transform.position, RotatingSpeed * size, RotatingSpeed * size);
                //Debug.Log(LocalTargetDirection + "and" + this.transform.up + "and" + rooo);
                //this.transform.rotation = Quaternion.LookRotation(rooo);
                //LocalTargetDirection = new Vector3(LocalTargetDirection.x, LocalTargetDirection.y - this.transform.position.y, LocalTargetDirection.z);
                /*if (DisableHTracking.IsActive)
                {
                    LocalTargetDirection = new Vector3(this.transform.right.x, LocalTargetDirection.y, this.transform.right.z);
                }*/
                if (DisableVTracking.IsActive)
                {
                    LocalTargetDirection = new Vector3(LocalTargetDirection.x, this.transform.right.y, LocalTargetDirection.z);
                }
                float Difference = Vector3.Angle(transform.forward, LocalTargetDirection - this.transform.position * 1);
                if (Difference > 精度.Value)
                {
                    this.GetComponent<Rigidbody>().angularVelocity = (getCorrTorque(this.transform.right, LocalTargetDirection - this.transform.position * 1, this.GetComponent<Rigidbody>(), 0.01f * size) * Mathf.Rad2Deg).normalized * RotatingSpeed;
                }
                else
                {
                    this.GetComponent<Rigidbody>().angularVelocity = (getCorrTorque(this.transform.right, LocalTargetDirection - this.transform.position * 1, this.GetComponent<Rigidbody>(), 0.01f * size) * Mathf.Rad2Deg);
                }
                //this.GetComponent<Rigidbody>().angularVelocity = (getCorrTorque(this.transform.right, LocalTargetDirection - this.transform.position * 1, this.GetComponent<Rigidbody>(), 0.01f * size) * Mathf.Rad2Deg).normalized * RotatingSpeed;
                float mag = (this.transform.right.normalized - LocalTargetDirection.normalized).magnitude;
                if (Vector3.Angle(transform.right, LocalTargetDirection - this.transform.position * 1) > 0.01f * 精度.Value)
                {
                    this.GetComponent<Rigidbody>().freezeRotation = false;
                    Audio.volume = mag * 0.2f * Math.Max((10 / (Vector3.Distance(this.transform.position, GameObject.Find("Main Camera").transform.position))), 1);
                    Audio.Play();
                }
                else
                {
                    this.GetComponent<Rigidbody>().freezeRotation = true;
                    Audio.Stop();
                }
            }
        }
        void OverLoadExplosion()
        {
            GameObject explo = (GameObject)GameObject.Instantiate(PrefabMaster.BlockPrefabs[59].gameObject, this.transform.position, this.transform.rotation);
            explo.transform.localScale = Vector3.one * 0.01f;
            TimedRocket ac = explo.GetComponent<TimedRocket>();
            ac.SetSlip(Color.white);
            ac.radius = 0.00001f;
            ac.power = 0.00001f;
            ac.randomDelay = 0.000001f;
            ac.upPower = 0;
            ac.StartCoroutine(ac.Explode(0.01f));
            explo.AddComponent<TimedSelfDestruct>();
        }
    }
    //Physics stuff
    public class TimedSelfDestruct : MonoBehaviour
    {
        float timer = 0;
        void FixedUpdate()
        {
            ++timer;
            if (timer > 260)
            {
                Destroy(this.gameObject);
            }
            if (this.GetComponent<TimedRocket>())
            {
                Destroy(this.GetComponent<TimedRocket>());
            }
        }
    }
}


