#! /usr/bin/env python
# -*- coding: utf-8 -*-
"""
@Time ： 2024/3/5 0:50
@Auth ： Xq
@File ：ConfigHenanOms.py
@IDE ：PyCharm
"""
"""
根据部署的场站名称,修改或者注释添加序号和电场名称
1-11 是郑州集控的
现场部署的话 依照现场的uk 账号密码
例如 12 是雅润现场的
#  12 账号是现场的
"""
henan_wfname_dict_num_sxz = {
    # 1: "21",
    1: "1",
    # 2: "2",# 不用
    3: "3",
    4: "4",
    5: "5",
    6: "6",
    7: "7",
    8: "8",
    9: "9",
    10: "10",
    11: "11",
}
get_henan_url = F'https://172.21.10.3:19070/app-portal/index.html'

# henan_wfname_dict_num = {
#     1: "润清风电场",
#     2: "韬润风电场",
#     3: "雅润风电场",
#     4: "凯润风电场",
#     5: "嘉润风电场",
#     6: "泉山风电场",
#     7: "润金风电场",
#     8: "驭风风电场",
#     9: "金燕风电场",
#     10: "飞翔风电场",
#     11: "泽润风电场",
# }
