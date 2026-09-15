"use client";

import React, { FC, PropsWithChildren } from "react";
import {
  GlobalStateProvider,
  ShaApplicationProvider,
  useNextRouter,
  MonacoLoaderSettings,
} from "@shesha-io/reactjs";
import { AppProgressBar } from "next-nprogress-bar";
import { useTheme } from "antd-style";

export interface IAppProviderProps {
  backendUrl: string;
}

// `shesha init` copies monaco-editor into public/monaco on install, so the code
// editor loads locally instead of reaching for a CDN.
const monacoSettings: MonacoLoaderSettings = { localPath: "/monaco/vs" };

export const AppProvider: FC<PropsWithChildren<IAppProviderProps>> = ({
  children,
  backendUrl,
}) => {
  const nextRouter = useNextRouter();
  const theme = useTheme();

  return (
    <GlobalStateProvider>
      <AppProgressBar height="4px" color={theme.colorPrimary} shallowRouting />
      <ShaApplicationProvider
        backendUrl={backendUrl}
        router={nextRouter}
        noAuth={nextRouter.path?.includes('/no-auth')}
        monaco={monacoSettings}
      >
        {children}
      </ShaApplicationProvider>
    </GlobalStateProvider>
  );
};
