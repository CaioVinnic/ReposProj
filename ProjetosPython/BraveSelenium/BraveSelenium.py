from selenium import webdriver
import time

# a ideia é automatizar o scroll de anuncios na aba do brave pra farmar BAT no brave rewards

brave_path = "C:\\Program Files\\BraveSoftware\\Brave-Browser\\Application\\brave.exe"
option = webdriver.ChromeOptions()

option.binary_location = brave_path

driver = webdriver.Chrome("C:\\Program Files (x86)\\ChromeDriver_win32\\chromedriver.exe", options=option)
driver.maximize_window()
time.sleep(5)

# testanto na url do YT, mas depois fazer na aba de anuncio do Brave
driver.get(url = "https://youtube.com/")
time.sleep(5)

i = 1
while i < 100000:
    driver.execute_script(f"window.scrollTo(0, {i})")
    i = i+1
    
time.sleep(5)

#driver.close()