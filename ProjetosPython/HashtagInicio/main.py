import time
from selenium import webdriver
from selenium.webdriver.common.by import By

driver = webdriver.Chrome()

emblema = 'COMEDIANTENAGRINGA'

#acessa o site
driver.get('https://nv99.com.br/')
time.sleep(3)

#abre login
driver.find_element(by = By.XPATH, value = '//*[@id="__next"]/header/div[2]/button[1]').click()

#email
driver.find_element(by = By.XPATH, value = '//*[@id="modal"]/div/section/div/div[2]/div[2]/div[2]/form/div[3]/div[1]/div/input').send_keys('caio.96.silva@gmail.com')
time.sleep(0)

#senha
driver.find_element(by = By.XPATH, value = '//*[@id="modal"]/div/section/div/div[2]/div[2]/div[2]/form/div[3]/div[2]/div[1]/div/input').send_keys('//Flow.10')
time.sleep(0)

#entrar
driver.find_element(by = By.XPATH, value = '//*[@id="modal"]/div/section/div/div[2]/div[2]/div[2]/form/div[4]/button').click()
time.sleep(3)

#abre aba perfil
driver.find_element(by = By.ID, value = 'contained-drawer-ltCg').click()
time.sleep(0)


#resgatar emblema
driver.find_element(by = By.XPATH, value = '//*[@id="__next"]/header/div[2]/div/div[4]/div/div[2]/a[4]/div').click()
time.sleep(0)

#insere emblema
driver.find_element(by = By.XPATH, value = '//*[@id="modal"]/div/section/form/div/div/input').send_keys(emblema)
time.sleep(0)

#resgatar
driver.find_element(by = By.XPATH, value = '//*[@id="modal"]/div/footer/div/button[2]').click()
time.sleep(1)

#confirma resgate
driver.find_element(by = By.XPATH, value = '//*[@id="modal"]/div/section/div[2]/div[3]/button[1]').click()


