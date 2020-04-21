using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //Параметры героя
    public float speed;
    public float jumpForce;
    private Vector2 startPosition;
    //Задержка прыжка
    private float nextJump;
    public float delayJump;
    private bool isAir;
    //номер уровня
    public int sceneName;
    //Физическое тело
    private Rigidbody2D rb;
    //В инвартаре
    private static bool isKey;
    private Transform Key;
    private Vector2 keyPosition;
    private int turns = 0;
    public int LieDoor = 0;

    //Субтитры
    public Text Sub;
    private float lifeTimeText;

    //First Sub
    private bool isStart = true;
    private bool firtsDeath = true;
    private bool firstLift = true;

    //
    //Начало
    //
    void Start()
    {
        isKey = false;
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        switch(sceneName)
        {
            case 1:
                StartCoroutine(StartSub1());
                break;
            case 2:
                StartCoroutine(StartSub2());
                break;
            case 3:
                StartCoroutine(StartSub3());
                break;
            case 4:
                StartCoroutine(StartSub4());
                break;
            case 5:
                StartCoroutine(StartSub5());
                break;
            case 6:
                StartCoroutine(StartSub6());
                break;
        }
    }

    //
    //Субтитры
    //
    private void SubsText(string sub, float lifeTime, float delay = 0)
    {
        Sub.text = sub;
        lifeTimeText = lifeTime;
    }

    //
    //Первый уровень
    //
    private IEnumerator Exit1()
    {
        SubsText("--это дверь, может это выход надо узнать это", 2.5f);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(++sceneName, LoadSceneMode.Single);
        isKey = false;
    }

    private IEnumerator PlatrformMessage()
    {
        SubsText("-что это было земля появилась из не откуда, и почему она двигается вверх и вниз..", 2.5f);
        yield return new WaitForSeconds(2.5f);
        SubsText("-ладно может мне туда и надо.", 1.5f);
    }

    private IEnumerator StartSub1()
    {
        while (isStart)
        {
            lifeTimeText = 15;

            Sub.text = "-где я?";
            yield return new WaitForSeconds(1.5f);

            Sub.text = "-что это за место почему земля парит в воздухе , АААА … где мои руки и ноги?";
            yield return new WaitForSeconds(2.5f);

            Sub.text = "-Почему я здесь? ";
            yield return new WaitForSeconds(1.5f);

            Sub.text = "-ничего не помню….";
            yield return new WaitForSeconds(1.5f);

            Sub.text = "-так, на сколько я понял, я должен идти дальше что б узнать что случилось ";
            yield return new WaitForSeconds(2.5f);

            lifeTimeText = 0;
            isStart = false;
        }
        Sub.text = "";
        yield return new WaitForSeconds(1);
    }

    //
    //Второй уровень
    //
    private IEnumerator StartSub2()
    {
        while (isStart)
        {
            lifeTimeText = 15;

            Sub.text = "-вход завален, я не вернусь назад, что делать?";
            yield return new WaitForSeconds(2.5f);

            Sub.text = "-я только что был на улице, а сейчас я в пещере";
            yield return new WaitForSeconds(2.5f);
            Sub.text = "странно как та дверь которая была над землей привела меня под землю";
            yield return new WaitForSeconds(2.5f);

            Sub.text = "-ладно не думай просто иди дальше";
            yield return new WaitForSeconds(2);

            Sub.text = "-дальше…. Куда дальше?…";
            yield return new WaitForSeconds(2);

            lifeTimeText = 0;
            isStart = false;
        }
        Sub.text = "";
        yield return new WaitForSeconds(1);
    }

    private IEnumerator Exit2()
    {
        SubsText("-я смог это сделать, это было страшно, но почему тут такая странная пещера", 2.5f);
        yield return new WaitForSeconds(2.5f);
        SubsText("-ладно не важно мне надо узнать как я сюда попал, надо идти дальше", 2);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(++sceneName, LoadSceneMode.Single);
        isKey = false;
    }

    //
    //Третий уровень
    //
    private IEnumerator StartSub3()
    {
        while (isStart)
        {
            lifeTimeText = 2.5f;

            Sub.text = "-Что тут твориться, я был на улице и в пещере, а сейчас я в странном кирпичном помещении";
            yield return new WaitForSeconds(2.5f);
            isStart = false;
            lifeTimeText = 0;
        }
        Sub.text = "";
        yield return new WaitForSeconds(1);
    }

    private IEnumerator KeyText()
    {
        SubsText("-что это было ?!? как это произошло?", 2);
        yield return new WaitForSeconds(2);
        SubsText("-так что б тут не творилось надо к этому привыкнуть… что ж будет дальше? даже думать не хочу об этом", 2.5f);
    }

    //
    //Четвёртый уровень
    //
    private IEnumerator StartSub4()
    {
        while (isStart)
        {
            lifeTimeText = 15;

            Sub.text = "-что почему тут так темно?? ";
            yield return new WaitForSeconds(2.5f);

            Sub.text = "-ничего не видно…";
            yield return new WaitForSeconds(2.5f);
            Sub.text = "-ну может это и лучшему, удивляться нечему";
            yield return new WaitForSeconds(2.5f);
            isStart = false;
            lifeTimeText = 0;
        }
        Sub.text = "";
        yield return new WaitForSeconds(1);
    }

    private IEnumerator Exit4()
    {
        SubsText(" -Хух вот и дверь наконец-то", 2.5f);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(++sceneName, LoadSceneMode.Single);
        isKey = false;
    }
    //
    //Пятый уровень
    //
    private IEnumerator StartSub5()
    {
        while (isStart)
        {
            lifeTimeText = 15;

            Sub.text = "-так тут не темно я вижу коридоры ?...";
            yield return new WaitForSeconds(2.5f);

            lifeTimeText = 0;
            isStart = false;
        }
        Sub.text = "";
        yield return new WaitForSeconds(1);
    }

    private IEnumerator DoorText()
   {
        SubsText("-Да как так то??? ни одна дверь не ведет отсюда , что это за странный лабиринт такой???", 2.5f);
        yield return new WaitForSeconds(2.5f);
        SubsText("-я обошел все двери и ни одна не открывается", 2);
        yield return new WaitForSeconds(2);
        SubsText("-надо искать выход", 1.5f);
        yield return new WaitForSeconds(1.5f);
    }

    private IEnumerator Exit5()
    {
        SubsText("-я тут уже проходил, но не заходил сюда, была не была надо попробовать", 2.5f);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(++sceneName, LoadSceneMode.Single);
        isKey = false;
    }
    //
    //Шестой уровень
    //
    private IEnumerator StartSub6()
    {
        while (isStart)
        {
            lifeTimeText = 15;

            Sub.text = "- это был самый странный лабиринт , и что будет дальше";
            yield return new WaitForSeconds(2.5f);

            Sub.text = "-снова какая стронная комната";
            yield return new WaitForSeconds(1.5f);
            Sub.text = "-может опять есть секретные двери и ключ, ключ надо искать ключ";
            yield return new WaitForSeconds(2.5f);

            Sub.text = "- я хочу выбраться отсюда и узнать кто я, и почему я здесь";
            yield return new WaitForSeconds(2);

            lifeTimeText = 0;
            isStart = false;
        }
        Sub.text = "";
        yield return new WaitForSeconds(1);
    }
    //
    //
    //Управление
    //
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
    }

    private void Update()
    {
        lifeTimeText -= Time.deltaTime;
        if(lifeTimeText <= 0)
        {
            lifeTimeText = 0;
            Sub.text = "";
        }
        bool jump = Time.time > nextJump;
        if (Input.GetKeyDown(KeyCode.Space) && !isAir && jump)
        {
            Jump();
        }
    }

    private void Jump()
    {
        isAir = true;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        nextJump = delayJump + Time.time;
    }

    //
    //Столкновение
    //
    private void OnCollisionStay2D(Collision2D collision)
    {
        isAir = false;
        if (collision.collider.CompareTag("Lift"))
        {
            if (firstLift)
            {
                firstLift = false;
                switch (sceneName)
                {
                    case 1:
                        StartCoroutine(PlatrformMessage());
                        break;
                    case 2:
                        SubsText("- так на сколько я понял мне надо на нее", 2.5f);
                        break;
                }
            }
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Cliff"))
        {
            SubsText("-и как мне пробраться к двери?", 2);
        }

        if (collision.CompareTag("Respawn"))
        {
            isStart = false;
            transform.position = startPosition;
            if (isKey)
            {
                Key.gameObject.SetActive(true);
                isKey = false;
            }
            if (firtsDeath && sceneName == 1)
            {
                firtsDeath = false;
                SubsText("-Я умер, но снова тут", 2.5f);
            }
            else
            {
                SubsText("-...", 1.5f);
            }
        }

        if (collision.CompareTag("Key"))
        {
            isStart = false;
            isKey = true;
            keyPosition = collision.transform.position;
            Key = collision.gameObject.GetComponent<Transform>();
            Key.gameObject.SetActive(false);
            switch(sceneName)
            {
                case 2:
                    SubsText("-так я нашел ключ, а значит должна быть еще дверь, может она там за лавой, надо идти дальше", 3);
                    break;
                case 3:
                    StartCoroutine(KeyText());
                    break;
                case 4:
                    SubsText("-так это было на сложно , но я что то нащупал,  да это ж ключ , а значит есть и дверь", 3);
                    break;
                case 5:
                    SubsText("-У меня есть ключ надо искать дверь", 2.5f);
                    break;
            }
        }
        if (collision.CompareTag("LieDoor"))
        {
            if (LieDoor == 0)
            {
                SubsText("-странно не открывается может есть еще двери? надо искать…", 2.5f);
            }
            LieDoor++;
            collision.tag = "Lie";
            if (LieDoor == 5)
            {
                StartCoroutine(DoorText());
            }
        }
        if (collision.CompareTag("Door"))
        {
            if (isKey)
            {
                switch (sceneName)
                {
                    case 1:
                        StartCoroutine(Exit1());
                        break;
                    case 2:
                        StartCoroutine(Exit2());
                        break;
                    case 3:
                        SceneManager.LoadScene(++sceneName, LoadSceneMode.Single);
                        isKey = false;
                        break;
                    case 4:
                        StartCoroutine(Exit4());
                        break;
                    case 5:
                        if (LieDoor == 5)
                        {
                            StartCoroutine(Exit5());
                        }
                        break;
                }
            }
            else
            {
                SubsText("-Дверь?! Может это выход, но она заперта надо найти ключ", 2.5f);
            }
        }

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Turn"))
        {
            turns++;
            if (turns == 2)
            {
                SubsText("-Да это же лабиринт , надо искать выход…", 2.5f);
            }
        }
    }
}
