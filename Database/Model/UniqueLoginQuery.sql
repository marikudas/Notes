﻿ALTER TABLE Users WITH CHECK
ADD CONSTRAINT UQ_Users_Login UNIQUE (Login)