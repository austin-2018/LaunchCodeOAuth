"use strict";

import { app } from "../server";

import { index } from "./routes/index";
import { login } from "./routes/login";

export function router() {
	index();
	login();
}
