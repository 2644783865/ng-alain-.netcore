using System;
using System.Collections.Generic;
using System.Linq;
using asdf.Models;
using Microsoft.AspNetCore.Mvc;

namespace asdf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerApiBase
    {
        [HttpGet("")]
        public JsonResult Get()
        {
            return Output(new App
            {
                project = new Project()
                {
                    name = "ng-alain"
                },
                menu = new List<Menu>()
                {
                    new Menu()
                    {
                        text = "������",
                        group = true,
                        children = new List<Menu>()
                        {
                            new Menu()
                            {
                                text = "�Ǳ���",
                                link = "/dashboard",
                                icon = "anticon anticon-appstore-o"
                            },
                            new Menu()
                            {
                                text = "��ݲ˵�",
                                icon = "anticon anticon-rocket",
                                shortcut_root = true
                            }
                        }
                    },
                    new Menu()
                    {
                        text = "ҵ��",
                        group = true,
                        children = new List<Menu>()
                        {
                            new Menu()
                            {
                                text = "CMS",
                                icon = "anticon anticon-skin",
                                children = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        text = "CMS�б�",
                                        link = "/cms/list"
                                    },
                                    new Menu()
                                    {
                                        text = "ģ���б�",
                                        link = "/cms/module"
                                    }
                                }
                            }
                        }
                    }
                },
                user = new User()
                {
                    id = 1,
                    name = "cipchk"
                }
            });
        }
    }
}