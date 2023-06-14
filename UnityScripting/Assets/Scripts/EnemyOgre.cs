using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class EnemyOgre
    {
        // 초기화에 사용한다
        void Start()
        {
#if SHOW_DEBUG_MESSAGES
// SHOW_DEBUG_MESSAGES 선언이 활성화되었을 때만 실행된다
Debug.Log("Pos: " + transform.position.ToString());
#endif
            // #endif 바깥에 위치하므로 그냥 실행된다.
            Console.Write("Start function called");

        }
    }
}
