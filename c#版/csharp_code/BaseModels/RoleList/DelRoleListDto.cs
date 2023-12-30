﻿using FluentValidation;

namespace Zhuz.net.BaseModels.RoleList;

public class DelRoleListReq
{
    public int user_id { get; init; }
    public int role_id { get; init; }
}


public class DelRoleListVali:AbstractValidator<DelRoleListReq>
{
    public DelRoleListVali()
    {
        RuleFor(v=>v.user_id).NotNull().NotEmpty().WithMessage("用户id不能为空!");
        RuleFor(v=>v.role_id).NotNull().NotEmpty().WithMessage("角色id不能为空!");
    }
}