namespace HY_PIP
{
    internal class GenericOp
    {
        public static bool EStop = false;       // 紧急停止
        public static bool AutoMode = false;     // 自动模式，手动模式切换
        public static bool EStop_Manual = false;// 来自手动操作柜，显示屏柜体的急停按钮信号。
        public static bool EStop_Soft = false;// 来自显示屏。
        public static bool RequestZRN = false;// 请求原点回归。
                                              //        public static bool tempon = false;

        public static int xPos;             //
        public static int zPos;             //
        public static int xPos_servo;       // 伺服的位置X
        public static int zPos_servo;       // 伺服的位置Z
        public static int weight;
        public static int temperature1;            //1号水槽温度
        public static bool temp1;                  //1号水槽加热状态
        public static int temperature3;            //2号水槽温度
        public static bool temp3;                  //2号水槽加热状态

        public static bool temp4;                  //4号炉子加热状态
        public static int temperature41;           //4号炉子温度

        public static int temperature51;           //5号炉子上温区温度
        public static bool temp5;                  //5号炉子加热状态

        public static int temperature61;           //6号炉子上温区温度
        public static bool temp6;                  //6号炉子加热状态

        public static int temperature71;           //7号炉子上温区温度
        public static bool temp7;                  //7号炉子加热状态

        public static int temperature10;           //3号水槽温度
        public static bool temp10;                  //3号水槽加热状态

        public static int temperature111;          //11号炉子上温区温度
        public static bool temp11;                  //11号炉子加热状态

        public static int temperature121;          //12号炉子上温区温度
        public static bool temp12;                  //12号炉子加热状态


        public static int tmpTimeOffset = 0;

        public enum GTRY_ACTION_TYPE { NONE, FORWARD, BAKWARD, UP, DOWN, CLAMP, CLAMP_RELAX }

        public static GTRY_ACTION_TYPE manual_gtry_action;// 手动控制柜对应的龙门动作指令。

        public static int errCode;// 错误码
    }
}