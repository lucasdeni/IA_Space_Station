using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents; //Array de agentes

    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai"); //Busca objetos com a tag de 'ai' 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Ao clicar com o mouse 
        {
            RaycastHit hit; //Desenha o trajeto com base do raycast da camera para o ponto que o mouse apontou
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 500)) //
            {
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point); //Faz com que os agentes se movam ate o destino
            }
        }
    }
}